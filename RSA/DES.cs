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
    public partial class DES : Form
    {
        DES_Encryption des = new DES_Encryption();
        string ciph = string.Empty;
        string pla = string.Empty;
        public DES()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ciph = plaintext.Text;
            cipher.Text = des.DESEncryption(ciph, key1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pla = ciphertext.Text;
            plain.Text = des.DESDecryption(pla, key2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            plaintext.Clear();
            key1.Clear();
            cipher.Clear();
            ciphertext.Clear();
            key2.Clear();
            plain.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            First admin = new First();
            admin.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DES_Load(object sender, EventArgs e)
        {

        }
    }
}
