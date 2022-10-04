namespace RSA
{
    partial class RSA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.public_key = new System.Windows.Forms.TextBox();
            this.cipher_text = new System.Windows.Forms.TextBox();
            this.generate = new System.Windows.Forms.Button();
            this.plain_text = new System.Windows.Forms.TextBox();
            this.private_key = new System.Windows.Forms.TextBox();
            this.ecrypted = new System.Windows.Forms.TextBox();
            this.decrypted = new System.Windows.Forms.TextBox();
            this.encrypt = new System.Windows.Forms.Button();
            this.dencrypt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(243, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "RSA Encryption and Decryption";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // public_key
            // 
            this.public_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.public_key.Location = new System.Drawing.Point(52, 112);
            this.public_key.Multiline = true;
            this.public_key.Name = "public_key";
            this.public_key.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.public_key.Size = new System.Drawing.Size(271, 96);
            this.public_key.TabIndex = 1;
            this.public_key.Click += new System.EventHandler(this.key1);
            this.public_key.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cipher_text
            // 
            this.cipher_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cipher_text.Location = new System.Drawing.Point(630, 275);
            this.cipher_text.Multiline = true;
            this.cipher_text.Name = "cipher_text";
            this.cipher_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cipher_text.Size = new System.Drawing.Size(258, 99);
            this.cipher_text.TabIndex = 1;
            this.cipher_text.TextChanged += new System.EventHandler(this.cipher_text_TextChanged);
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(430, 143);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(97, 34);
            this.generate.TabIndex = 2;
            this.generate.Text = "Generate Keys";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.Generate);
            // 
            // plain_text
            // 
            this.plain_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plain_text.Location = new System.Drawing.Point(52, 275);
            this.plain_text.Multiline = true;
            this.plain_text.Name = "plain_text";
            this.plain_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.plain_text.Size = new System.Drawing.Size(271, 99);
            this.plain_text.TabIndex = 1;
            this.plain_text.TextChanged += new System.EventHandler(this.plain_text_TextChanged);
            // 
            // private_key
            // 
            this.private_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.private_key.Location = new System.Drawing.Point(630, 112);
            this.private_key.Multiline = true;
            this.private_key.Name = "private_key";
            this.private_key.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.private_key.Size = new System.Drawing.Size(258, 96);
            this.private_key.TabIndex = 1;
            // 
            // ecrypted
            // 
            this.ecrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecrypted.Location = new System.Drawing.Point(52, 420);
            this.ecrypted.Multiline = true;
            this.ecrypted.Name = "ecrypted";
            this.ecrypted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ecrypted.Size = new System.Drawing.Size(271, 98);
            this.ecrypted.TabIndex = 1;
            // 
            // decrypted
            // 
            this.decrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decrypted.Location = new System.Drawing.Point(630, 420);
            this.decrypted.Multiline = true;
            this.decrypted.Name = "decrypted";
            this.decrypted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.decrypted.Size = new System.Drawing.Size(258, 98);
            this.decrypted.TabIndex = 1;
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(133, 380);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(97, 34);
            this.encrypt.TabIndex = 2;
            this.encrypt.Text = "Encrypt";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // dencrypt
            // 
            this.dencrypt.Location = new System.Drawing.Point(716, 380);
            this.dencrypt.Name = "dencrypt";
            this.dencrypt.Size = new System.Drawing.Size(97, 34);
            this.dencrypt.TabIndex = 2;
            this.dencrypt.Text = "Decrypt";
            this.dencrypt.UseVisualStyleBackColor = true;
            this.dencrypt.Click += new System.EventHandler(this.dencrypt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(48, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Public Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(626, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Private Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(48, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Plain Text";
            this.label4.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(626, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cipher Text";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(419, 531);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(546, 531);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 34);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 71);
            this.panel1.TabIndex = 11;
            // 
            // RSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(958, 573);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dencrypt);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.private_key);
            this.Controls.Add(this.decrypted);
            this.Controls.Add(this.cipher_text);
            this.Controls.Add(this.ecrypted);
            this.Controls.Add(this.plain_text);
            this.Controls.Add(this.public_key);
            this.Name = "RSA";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox public_key;
        private System.Windows.Forms.TextBox cipher_text;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.TextBox plain_text;
        private System.Windows.Forms.TextBox private_key;
        private System.Windows.Forms.TextBox ecrypted;
        private System.Windows.Forms.TextBox decrypted;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Button dencrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel panel1;
    }
}

