using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA
{
    public partial class Caesar : Form
    {
        public Caesar()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (plaintext.Text!="")
            {
                if (key1.Text != "")
                {
                    int key = int.Parse(key1.Text);
                    string small = "abcdefghijklmnopqrstuvwxyz",
                        cap = small.ToUpper(),
                        result="";

                    for (int i = 0; i < plaintext.Text.Length; i++)
                    {
                        if(plaintext.Text[i]>='a' && plaintext.Text[i] <= 'z')
                        { 
                            result += small[((small.IndexOf(plaintext.Text[i])+key)%26)];
                        }
                        if (plaintext.Text[i] >= 'A' && plaintext.Text[i] <= 'Z')
                        {
                            result += cap[((cap.IndexOf(plaintext.Text[i]) + key) % 26)];
                        }
                    }
                    cipher.Text = result;
                }
                else
                    cipher.Text = "Please Enter The Key Frist ^_^ .";
            }
            else
                cipher.Text = "Please Enter The PlainText Frist ^_^ .";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (plaintext.Text != "")
            {
                if (key2.Text != "")
                {
                    int key = int.Parse(key2.Text);
                    string small = "abcdefghijklmnopqrstuvwxyz",
                        cap = small.ToUpper(),
                        result = "";

                    for (int i = 0; i < ciphertext.Text.Length; i++)
                    {
                        if (ciphertext.Text[i] >= 'a' && ciphertext.Text[i] <= 'z')
                        {
                            result += small[((small.IndexOf(ciphertext.Text[i]) - key + 26) % 26)];
                        }
                        if (ciphertext.Text[i] >= 'A' && ciphertext.Text[i] <= 'Z')
                        {
                            result += cap[((cap.IndexOf(ciphertext.Text[i]) + key + 26) % 26)];
                        }
                    }
                    plain.Text = result;
                }
                else
                    plain.Text = "Please Enter The Key Frist ^_^ .";
            }
            else
                plain.Text = "Please Enter The CipherText Frist ^_^ .";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            First admin = new First();
            admin.Show();
            this.Hide();
        }

        private void Caesar_Load(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            plaintext.Clear();
            key1.Clear();
            cipher.Clear();
            ciphertext.Clear();
            key2.Clear();
            plain.Clear();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
