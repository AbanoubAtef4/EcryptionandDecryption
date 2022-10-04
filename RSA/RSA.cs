using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Xml.Serialization;

namespace RSA
{
    public partial class RSA : Form
    {
        RSA_Encryption txt = new RSA_Encryption();
        string cipher = string.Empty;
        string plain = string.Empty;

        public RSA()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void Generate(object sender, EventArgs e)
        {
            
            public_key.Text = txt.getpublickey();
            private_key.Text = txt.getprivatekey();
            
        }

        private void key1(object sender, EventArgs e)
        {
           
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            if (public_key.Text != "")
            {
                if (plain_text.Text != "")
                {
                    cipher = plain_text.Text;
                    ecrypted.Text = txt.encrypt(cipher);
                }
                else
                {
                    ecrypted.Text = "Error : Please Enter The Plain Text ^_^ .";
                }
            }
            else
                ecrypted.Text = "Error : Please Generate The Key First ^_^ .";
        }

        private void cipher_text_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dencrypt_Click(object sender, EventArgs e)
        {
            if (private_key.Text != "")
            {


                if (cipher_text.Text != "")
                {
                    plain = cipher_text.Text;
                    decrypted.Text = txt.decrypt(plain);
                }
                else
                    decrypted.Text = "Error : Please Enter The Cipher Text ^_^ .";
            }
            else
                decrypted.Text = "Error : Please Generate The Key First ^_^ .";
        }
        


        private void plain_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            plain_text.Clear();
            cipher_text.Clear();
            decrypted.Clear();
            ecrypted.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            First admin = new First();
            admin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           /* Adminstrator admin = new Adminstrator();
            admin.Show();
            this.Hide();
           */
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}
