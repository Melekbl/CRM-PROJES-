namespace CRM.Proje1.UI
{
    partial class PersonelForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.personellerdataGridView = new System.Windows.Forms.DataGridView();
            this.uzmanliklabel = new System.Windows.Forms.Label();
            this.soyadlabel = new System.Windows.Forms.Label();
            this.adlabel = new System.Windows.Forms.Label();
            this.silbutton = new System.Windows.Forms.Button();
            this.kaydetbutton = new System.Windows.Forms.Button();
            this.uzmanlikcomboBox = new System.Windows.Forms.ComboBox();
            this.soyadtextBox = new System.Windows.Forms.TextBox();
            this.adtextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.personellerdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // personellerdataGridView
            // 
            this.personellerdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.personellerdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.personellerdataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.personellerdataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.personellerdataGridView.EnableHeadersVisualStyles = false;
            this.personellerdataGridView.Location = new System.Drawing.Point(0, 204);
            this.personellerdataGridView.MultiSelect = false;
            this.personellerdataGridView.Name = "personellerdataGridView";
            this.personellerdataGridView.ReadOnly = true;
            this.personellerdataGridView.RowHeadersVisible = false;
            this.personellerdataGridView.RowHeadersWidth = 51;
            this.personellerdataGridView.RowTemplate.Height = 24;
            this.personellerdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personellerdataGridView.Size = new System.Drawing.Size(609, 225);
            this.personellerdataGridView.TabIndex = 8;
            this.personellerdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personellerdataGridView_CellContentClick);
            // 
            // uzmanliklabel
            // 
            this.uzmanliklabel.AutoSize = true;
            this.uzmanliklabel.BackColor = System.Drawing.Color.Black;
            this.uzmanliklabel.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uzmanliklabel.ForeColor = System.Drawing.Color.White;
            this.uzmanliklabel.Location = new System.Drawing.Point(12, 114);
            this.uzmanliklabel.Name = "uzmanliklabel";
            this.uzmanliklabel.Size = new System.Drawing.Size(81, 18);
            this.uzmanliklabel.TabIndex = 20;
            this.uzmanliklabel.Text = "UZMANLIK";
            // 
            // soyadlabel
            // 
            this.soyadlabel.AutoSize = true;
            this.soyadlabel.BackColor = System.Drawing.Color.Black;
            this.soyadlabel.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyadlabel.ForeColor = System.Drawing.Color.White;
            this.soyadlabel.Location = new System.Drawing.Point(12, 65);
            this.soyadlabel.Name = "soyadlabel";
            this.soyadlabel.Size = new System.Drawing.Size(54, 18);
            this.soyadlabel.TabIndex = 19;
            this.soyadlabel.Text = "SOYAD";
            // 
            // adlabel
            // 
            this.adlabel.AutoSize = true;
            this.adlabel.BackColor = System.Drawing.Color.Black;
            this.adlabel.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adlabel.ForeColor = System.Drawing.Color.White;
            this.adlabel.Location = new System.Drawing.Point(12, 13);
            this.adlabel.Name = "adlabel";
            this.adlabel.Size = new System.Drawing.Size(28, 18);
            this.adlabel.TabIndex = 18;
            this.adlabel.Text = "AD";
            // 
            // silbutton
            // 
            this.silbutton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.silbutton.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silbutton.ForeColor = System.Drawing.Color.Black;
            this.silbutton.Location = new System.Drawing.Point(408, 34);
            this.silbutton.Name = "silbutton";
            this.silbutton.Size = new System.Drawing.Size(110, 101);
            this.silbutton.TabIndex = 17;
            this.silbutton.Text = "Sil";
            this.silbutton.UseVisualStyleBackColor = false;
            this.silbutton.Click += new System.EventHandler(this.silbutton_Click);
            // 
            // kaydetbutton
            // 
            this.kaydetbutton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.kaydetbutton.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetbutton.ForeColor = System.Drawing.Color.Black;
            this.kaydetbutton.Location = new System.Drawing.Point(286, 35);
            this.kaydetbutton.Name = "kaydetbutton";
            this.kaydetbutton.Size = new System.Drawing.Size(103, 98);
            this.kaydetbutton.TabIndex = 16;
            this.kaydetbutton.Text = "Kaydet";
            this.kaydetbutton.UseVisualStyleBackColor = false;
            this.kaydetbutton.Click += new System.EventHandler(this.kaydetbutton_Click);
            // 
            // uzmanlikcomboBox
            // 
            this.uzmanlikcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uzmanlikcomboBox.FormattingEnabled = true;
            this.uzmanlikcomboBox.Items.AddRange(new object[] {
            "Ön Büro Şefi ",
            "",
            "Resepsiyonist",
            " ",
            "",
            "Gece Müdürü ",
            "",
            "",
            "Misafir İlişkileri ",
            "",
            "",
            "Teknik Servis Uzmanı ",
            "",
            "",
            "Kat Hizmetleri Sorumlusu ",
            "",
            "",
            "Bilgi İşlem Destek ",
            "",
            "",
            "Rezervasyon Memuru"});
            this.uzmanlikcomboBox.Location = new System.Drawing.Point(114, 114);
            this.uzmanlikcomboBox.Name = "uzmanlikcomboBox";
            this.uzmanlikcomboBox.Size = new System.Drawing.Size(121, 24);
            this.uzmanlikcomboBox.TabIndex = 15;
            this.uzmanlikcomboBox.SelectedIndexChanged += new System.EventHandler(this.uzmanlikcomboBox_SelectedIndexChanged);
            // 
            // soyadtextBox
            // 
            this.soyadtextBox.Location = new System.Drawing.Point(114, 61);
            this.soyadtextBox.Name = "soyadtextBox";
            this.soyadtextBox.Size = new System.Drawing.Size(100, 22);
            this.soyadtextBox.TabIndex = 14;
            // 
            // adtextBox
            // 
            this.adtextBox.Location = new System.Drawing.Point(114, 9);
            this.adtextBox.Name = "adtextBox";
            this.adtextBox.Size = new System.Drawing.Size(100, 22);
            this.adtextBox.TabIndex = 13;
            // 
            // PersonelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(609, 429);
            this.Controls.Add(this.uzmanliklabel);
            this.Controls.Add(this.soyadlabel);
            this.Controls.Add(this.adlabel);
            this.Controls.Add(this.silbutton);
            this.Controls.Add(this.kaydetbutton);
            this.Controls.Add(this.uzmanlikcomboBox);
            this.Controls.Add(this.soyadtextBox);
            this.Controls.Add(this.adtextBox);
            this.Controls.Add(this.personellerdataGridView);
            this.Name = "PersonelForm";
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.Personel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personellerdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView personellerdataGridView;
        private System.Windows.Forms.Label uzmanliklabel;
        private System.Windows.Forms.Label soyadlabel;
        private System.Windows.Forms.Label adlabel;
        private System.Windows.Forms.Button silbutton;
        private System.Windows.Forms.Button kaydetbutton;
        private System.Windows.Forms.ComboBox uzmanlikcomboBox;
        private System.Windows.Forms.TextBox soyadtextBox;
        private System.Windows.Forms.TextBox adtextBox;
    }
}