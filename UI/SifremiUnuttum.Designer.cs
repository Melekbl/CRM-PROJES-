namespace CRM.Proje1.UI
{
    partial class SifremiUnuttum
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
            this.guncellebutton = new System.Windows.Forms.Button();
            this.kullaniciaditextBox = new System.Windows.Forms.TextBox();
            this.yenisifretextBox = new System.Windows.Forms.TextBox();
            this.Kullaniciadilabel = new System.Windows.Forms.Label();
            this.yenisifrelabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guncellebutton
            // 
            this.guncellebutton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.guncellebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncellebutton.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncellebutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guncellebutton.Location = new System.Drawing.Point(234, 81);
            this.guncellebutton.Name = "guncellebutton";
            this.guncellebutton.Size = new System.Drawing.Size(114, 54);
            this.guncellebutton.TabIndex = 0;
            this.guncellebutton.Text = "GÜNCELLE";
            this.guncellebutton.UseVisualStyleBackColor = false;
            this.guncellebutton.Click += new System.EventHandler(this.guncellebutton_Click);
            // 
            // kullaniciaditextBox
            // 
            this.kullaniciaditextBox.Location = new System.Drawing.Point(107, 59);
            this.kullaniciaditextBox.Name = "kullaniciaditextBox";
            this.kullaniciaditextBox.Size = new System.Drawing.Size(100, 22);
            this.kullaniciaditextBox.TabIndex = 1;
            // 
            // yenisifretextBox
            // 
            this.yenisifretextBox.Location = new System.Drawing.Point(107, 119);
            this.yenisifretextBox.Name = "yenisifretextBox";
            this.yenisifretextBox.Size = new System.Drawing.Size(100, 22);
            this.yenisifretextBox.TabIndex = 2;
            // 
            // Kullaniciadilabel
            // 
            this.Kullaniciadilabel.AutoSize = true;
            this.Kullaniciadilabel.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kullaniciadilabel.ForeColor = System.Drawing.Color.White;
            this.Kullaniciadilabel.Location = new System.Drawing.Point(3, 59);
            this.Kullaniciadilabel.Name = "Kullaniciadilabel";
            this.Kullaniciadilabel.Size = new System.Drawing.Size(95, 16);
            this.Kullaniciadilabel.TabIndex = 3;
            this.Kullaniciadilabel.Text = "KULLANICI ADI";
            // 
            // yenisifrelabel
            // 
            this.yenisifrelabel.AutoSize = true;
            this.yenisifrelabel.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yenisifrelabel.ForeColor = System.Drawing.Color.White;
            this.yenisifrelabel.Location = new System.Drawing.Point(3, 119);
            this.yenisifrelabel.Name = "yenisifrelabel";
            this.yenisifrelabel.Size = new System.Drawing.Size(84, 18);
            this.yenisifrelabel.TabIndex = 4;
            this.yenisifrelabel.Text = "YENİ ŞİFRE";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guncellebutton);
            this.panel1.Controls.Add(this.yenisifrelabel);
            this.panel1.Controls.Add(this.kullaniciaditextBox);
            this.panel1.Controls.Add(this.yenisifretextBox);
            this.panel1.Controls.Add(this.Kullaniciadilabel);
            this.panel1.Location = new System.Drawing.Point(99, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 187);
            this.panel1.TabIndex = 5;
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(553, 295);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "SifremiUnuttum";
            this.Text = "SifremiUnuttum";
            this.Load += new System.EventHandler(this.SifremiUnuttum_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button guncellebutton;
        private System.Windows.Forms.TextBox kullaniciaditextBox;
        private System.Windows.Forms.TextBox yenisifretextBox;
        private System.Windows.Forms.Label Kullaniciadilabel;
        private System.Windows.Forms.Label yenisifrelabel;
        private System.Windows.Forms.Panel panel1;
    }
}