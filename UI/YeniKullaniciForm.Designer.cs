namespace CRM.Proje1.UI
{
    partial class YeniKullaniciForm
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
            this.rolcomboBox = new System.Windows.Forms.ComboBox();
            this.kullaniciaditextBox = new System.Windows.Forms.TextBox();
            this.sifretextBox = new System.Windows.Forms.TextBox();
            this.kullaniciadilabel = new System.Windows.Forms.Label();
            this.sifreabel = new System.Windows.Forms.Label();
            this.rollabel = new System.Windows.Forms.Label();
            this.kaydetbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rolcomboBox
            // 
            this.rolcomboBox.FormattingEnabled = true;
            this.rolcomboBox.Items.AddRange(new object[] {
            "Admin",
            "Çağrı Personeli",
            "Destek Personeli"});
            this.rolcomboBox.Location = new System.Drawing.Point(112, 120);
            this.rolcomboBox.Name = "rolcomboBox";
            this.rolcomboBox.Size = new System.Drawing.Size(121, 24);
            this.rolcomboBox.TabIndex = 0;
            this.rolcomboBox.SelectedIndexChanged += new System.EventHandler(this.rolcomboBox_SelectedIndexChanged);
            // 
            // kullaniciaditextBox
            // 
            this.kullaniciaditextBox.Location = new System.Drawing.Point(112, 22);
            this.kullaniciaditextBox.Name = "kullaniciaditextBox";
            this.kullaniciaditextBox.Size = new System.Drawing.Size(100, 22);
            this.kullaniciaditextBox.TabIndex = 1;
            // 
            // sifretextBox
            // 
            this.sifretextBox.Location = new System.Drawing.Point(112, 74);
            this.sifretextBox.Name = "sifretextBox";
            this.sifretextBox.Size = new System.Drawing.Size(100, 22);
            this.sifretextBox.TabIndex = 2;
            // 
            // kullaniciadilabel
            // 
            this.kullaniciadilabel.AutoSize = true;
            this.kullaniciadilabel.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciadilabel.ForeColor = System.Drawing.Color.White;
            this.kullaniciadilabel.Location = new System.Drawing.Point(12, 22);
            this.kullaniciadilabel.Name = "kullaniciadilabel";
            this.kullaniciadilabel.Size = new System.Drawing.Size(91, 18);
            this.kullaniciadilabel.TabIndex = 3;
            this.kullaniciadilabel.Text = "Kullanıcı Adı";
            // 
            // sifreabel
            // 
            this.sifreabel.AutoSize = true;
            this.sifreabel.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreabel.ForeColor = System.Drawing.Color.White;
            this.sifreabel.Location = new System.Drawing.Point(18, 74);
            this.sifreabel.Name = "sifreabel";
            this.sifreabel.Size = new System.Drawing.Size(40, 18);
            this.sifreabel.TabIndex = 4;
            this.sifreabel.Text = "Şifre";
            // 
            // rollabel
            // 
            this.rollabel.AutoSize = true;
            this.rollabel.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rollabel.ForeColor = System.Drawing.Color.White;
            this.rollabel.Location = new System.Drawing.Point(18, 120);
            this.rollabel.Name = "rollabel";
            this.rollabel.Size = new System.Drawing.Size(30, 18);
            this.rollabel.TabIndex = 5;
            this.rollabel.Text = "Rol";
            // 
            // kaydetbutton
            // 
            this.kaydetbutton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.kaydetbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kaydetbutton.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetbutton.Location = new System.Drawing.Point(283, 74);
            this.kaydetbutton.Name = "kaydetbutton";
            this.kaydetbutton.Size = new System.Drawing.Size(86, 62);
            this.kaydetbutton.TabIndex = 6;
            this.kaydetbutton.Text = "KAYDET";
            this.kaydetbutton.UseVisualStyleBackColor = false;
            this.kaydetbutton.Click += new System.EventHandler(this.kaydetbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.kullaniciaditextBox);
            this.panel1.Controls.Add(this.kaydetbutton);
            this.panel1.Controls.Add(this.kullaniciadilabel);
            this.panel1.Controls.Add(this.rollabel);
            this.panel1.Controls.Add(this.sifretextBox);
            this.panel1.Controls.Add(this.rolcomboBox);
            this.panel1.Controls.Add(this.sifreabel);
            this.panel1.Location = new System.Drawing.Point(30, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 262);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // YeniKullaniciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(500, 306);
            this.Controls.Add(this.panel1);
            this.Name = "YeniKullaniciForm";
            this.Text = "Yeni Kullanıcı";
            this.Load += new System.EventHandler(this.YeniKullaniciForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox rolcomboBox;
        private System.Windows.Forms.TextBox kullaniciaditextBox;
        private System.Windows.Forms.TextBox sifretextBox;
        private System.Windows.Forms.Label kullaniciadilabel;
        private System.Windows.Forms.Label sifreabel;
        private System.Windows.Forms.Label rollabel;
        private System.Windows.Forms.Button kaydetbutton;
        private System.Windows.Forms.Panel panel1;
    }
}