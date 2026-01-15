namespace CRM.Proje1
{
    partial class LoginForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.kullaniciaditextBox = new System.Windows.Forms.TextBox();
            this.sifremiunuttumbutton = new System.Windows.Forms.Button();
            this.yenikullaniciolusturbutton = new System.Windows.Forms.Button();
            this.sifrelabel = new System.Windows.Forms.Label();
            this.kullaniciadilabel = new System.Windows.Forms.Label();
            this.girisbutton = new System.Windows.Forms.Button();
            this.sifretextBox = new System.Windows.Forms.TextBox();
            this.loginpanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.loginpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 599);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Location = new System.Drawing.Point(207, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(473, 582);
            this.panel3.TabIndex = 13;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CRM.Proje1.Properties.Resources.Gemini_Generated_Image_dtn8zrdtn8zrdtn8;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.piclogo_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(40, 258);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 28);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(40, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "Şifremi Unuttum ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.sifremiunuttumbutton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(260, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 46);
            this.button2.TabIndex = 12;
            this.button2.Text = "Yeni Kullanıcı Oluştur";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.yenikullaniciolusturbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "ŞİFRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "KULLANICI ADI";
            this.label2.Click += new System.EventHandler(this.kullaniciadilabel_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Goldenrod;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(159, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 46);
            this.button3.TabIndex = 6;
            this.button3.Text = "GİRİŞ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.girisbutton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(40, 348);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(312, 28);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.sifre_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.piclogo);
            this.panel1.Controls.Add(this.kullaniciaditextBox);
            this.panel1.Controls.Add(this.sifremiunuttumbutton);
            this.panel1.Controls.Add(this.yenikullaniciolusturbutton);
            this.panel1.Controls.Add(this.sifrelabel);
            this.panel1.Controls.Add(this.kullaniciadilabel);
            this.panel1.Controls.Add(this.girisbutton);
            this.panel1.Controls.Add(this.sifretextBox);
            this.panel1.Location = new System.Drawing.Point(207, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 544);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // piclogo
            // 
            this.piclogo.Image = global::CRM.Proje1.Properties.Resources.Gemini_Generated_Image_dtn8zrdtn8zrdtn8;
            this.piclogo.Location = new System.Drawing.Point(0, 3);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(482, 194);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogo.TabIndex = 13;
            this.piclogo.TabStop = false;
            this.piclogo.Click += new System.EventHandler(this.piclogo_Click);
            // 
            // kullaniciaditextBox
            // 
            this.kullaniciaditextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciaditextBox.Location = new System.Drawing.Point(40, 258);
            this.kullaniciaditextBox.Name = "kullaniciaditextBox";
            this.kullaniciaditextBox.Size = new System.Drawing.Size(312, 28);
            this.kullaniciaditextBox.TabIndex = 3;
            // 
            // sifremiunuttumbutton
            // 
            this.sifremiunuttumbutton.Location = new System.Drawing.Point(40, 468);
            this.sifremiunuttumbutton.Name = "sifremiunuttumbutton";
            this.sifremiunuttumbutton.Size = new System.Drawing.Size(128, 46);
            this.sifremiunuttumbutton.TabIndex = 11;
            this.sifremiunuttumbutton.Text = "Şifremi unuttum ";
            this.sifremiunuttumbutton.UseVisualStyleBackColor = true;
            this.sifremiunuttumbutton.Click += new System.EventHandler(this.sifremiunuttumbutton_Click);
            // 
            // yenikullaniciolusturbutton
            // 
            this.yenikullaniciolusturbutton.Location = new System.Drawing.Point(260, 468);
            this.yenikullaniciolusturbutton.Name = "yenikullaniciolusturbutton";
            this.yenikullaniciolusturbutton.Size = new System.Drawing.Size(128, 46);
            this.yenikullaniciolusturbutton.TabIndex = 12;
            this.yenikullaniciolusturbutton.Text = "Yeni Kullanıcı oluştur";
            this.yenikullaniciolusturbutton.UseVisualStyleBackColor = true;
            this.yenikullaniciolusturbutton.Click += new System.EventHandler(this.yenikullaniciolusturbutton_Click);
            // 
            // sifrelabel
            // 
            this.sifrelabel.AutoSize = true;
            this.sifrelabel.Location = new System.Drawing.Point(37, 311);
            this.sifrelabel.Name = "sifrelabel";
            this.sifrelabel.Size = new System.Drawing.Size(34, 16);
            this.sifrelabel.TabIndex = 4;
            this.sifrelabel.Text = "Şifre";
            // 
            // kullaniciadilabel
            // 
            this.kullaniciadilabel.AutoSize = true;
            this.kullaniciadilabel.ForeColor = System.Drawing.Color.Black;
            this.kullaniciadilabel.Location = new System.Drawing.Point(37, 223);
            this.kullaniciadilabel.Name = "kullaniciadilabel";
            this.kullaniciadilabel.Size = new System.Drawing.Size(98, 16);
            this.kullaniciadilabel.TabIndex = 2;
            this.kullaniciadilabel.Text = "KULLANICI ADI";
            this.kullaniciadilabel.Click += new System.EventHandler(this.kullaniciadilabel_Click);
            // 
            // girisbutton
            // 
            this.girisbutton.BackColor = System.Drawing.Color.Goldenrod;
            this.girisbutton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisbutton.Location = new System.Drawing.Point(149, 400);
            this.girisbutton.Name = "girisbutton";
            this.girisbutton.Size = new System.Drawing.Size(128, 46);
            this.girisbutton.TabIndex = 6;
            this.girisbutton.Text = "GİRİŞ";
            this.girisbutton.UseVisualStyleBackColor = false;
            this.girisbutton.Click += new System.EventHandler(this.girisbutton_Click);
            // 
            // sifretextBox
            // 
            this.sifretextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.sifretextBox.Location = new System.Drawing.Point(40, 348);
            this.sifretextBox.Name = "sifretextBox";
            this.sifretextBox.Size = new System.Drawing.Size(293, 23);
            this.sifretextBox.TabIndex = 5;
            // 
            // loginpanel
            // 
            this.loginpanel.BackColor = System.Drawing.Color.Black;
            this.loginpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginpanel.Controls.Add(this.panel2);
            this.loginpanel.Location = new System.Drawing.Point(0, 0);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(854, 586);
            this.loginpanel.TabIndex = 4;
            this.loginpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginpanel_Paint);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(837, 585);
            this.Controls.Add(this.loginpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.loginpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.TextBox kullaniciaditextBox;
        private System.Windows.Forms.Button sifremiunuttumbutton;
        private System.Windows.Forms.Button yenikullaniciolusturbutton;
        private System.Windows.Forms.Label sifrelabel;
        private System.Windows.Forms.Label kullaniciadilabel;
        private System.Windows.Forms.Button girisbutton;
        private System.Windows.Forms.TextBox sifretextBox;
        private System.Windows.Forms.Panel loginpanel;
    }
}

