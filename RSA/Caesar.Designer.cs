namespace RSA
{
    partial class Caesar
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
            this.plaintext = new System.Windows.Forms.TextBox();
            this.key1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cipher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.key = new System.Windows.Forms.Label();
            this.Cipher1 = new System.Windows.Forms.Label();
            this.ciphertext = new System.Windows.Forms.TextBox();
            this.plain = new System.Windows.Forms.TextBox();
            this.key2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plaintext
            // 
            this.plaintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plaintext.Location = new System.Drawing.Point(124, 107);
            this.plaintext.Multiline = true;
            this.plaintext.Name = "plaintext";
            this.plaintext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.plaintext.Size = new System.Drawing.Size(318, 62);
            this.plaintext.TabIndex = 0;
            // 
            // key1
            // 
            this.key1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key1.Location = new System.Drawing.Point(124, 185);
            this.key1.Multiline = true;
            this.key1.Name = "key1";
            this.key1.Size = new System.Drawing.Size(102, 29);
            this.key1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(283, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 37);
            this.button3.TabIndex = 1;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cipher
            // 
            this.cipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cipher.Location = new System.Drawing.Point(124, 300);
            this.cipher.Multiline = true;
            this.cipher.Name = "cipher";
            this.cipher.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cipher.Size = new System.Drawing.Size(318, 62);
            this.cipher.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plain Text";
            // 
            // key
            // 
            this.key.AutoSize = true;
            this.key.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.key.Location = new System.Drawing.Point(17, 188);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(42, 22);
            this.key.TabIndex = 2;
            this.key.Text = "Key";
            // 
            // Cipher1
            // 
            this.Cipher1.AutoSize = true;
            this.Cipher1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cipher1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Cipher1.Location = new System.Drawing.Point(12, 316);
            this.Cipher1.Name = "Cipher1";
            this.Cipher1.Size = new System.Drawing.Size(106, 22);
            this.Cipher1.TabIndex = 2;
            this.Cipher1.Text = "Cipher Text";
            // 
            // ciphertext
            // 
            this.ciphertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciphertext.Location = new System.Drawing.Point(609, 107);
            this.ciphertext.Multiline = true;
            this.ciphertext.Name = "ciphertext";
            this.ciphertext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ciphertext.Size = new System.Drawing.Size(318, 62);
            this.ciphertext.TabIndex = 0;
            // 
            // plain
            // 
            this.plain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plain.Location = new System.Drawing.Point(609, 300);
            this.plain.Multiline = true;
            this.plain.Name = "plain";
            this.plain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.plain.Size = new System.Drawing.Size(318, 62);
            this.plain.TabIndex = 0;
            // 
            // key2
            // 
            this.key2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key2.Location = new System.Drawing.Point(609, 185);
            this.key2.Multiline = true;
            this.key2.Name = "key2";
            this.key2.Size = new System.Drawing.Size(102, 29);
            this.key2.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(609, 242);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 37);
            this.button5.TabIndex = 1;
            this.button5.Text = "Decrypt";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(497, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cipher Text";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(497, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Plain Text";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(497, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(210, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(541, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Caesar Encryption and Decryption";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(553, 387);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 40);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(422, 387);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(100, 40);
            this.Reset.TabIndex = 9;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 77);
            this.panel1.TabIndex = 10;
            // 
            // Caesar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(955, 436);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cipher1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.key);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.key2);
            this.Controls.Add(this.key1);
            this.Controls.Add(this.plain);
            this.Controls.Add(this.cipher);
            this.Controls.Add(this.ciphertext);
            this.Controls.Add(this.plaintext);
            this.Name = "Caesar";
            this.Text = "Caesar";
            this.Load += new System.EventHandler(this.Caesar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox plaintext;
        private System.Windows.Forms.TextBox key1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox cipher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label key;
        private System.Windows.Forms.Label Cipher1;
        private System.Windows.Forms.TextBox ciphertext;
        private System.Windows.Forms.TextBox plain;
        private System.Windows.Forms.TextBox key2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Panel panel1;
    }
}