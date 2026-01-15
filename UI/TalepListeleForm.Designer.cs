namespace CRM.Proje1.UI
{
    partial class TalepListeleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.anapanel = new System.Windows.Forms.Panel();
            this.talepdataGridView = new System.Windows.Forms.DataGridView();
            this.TalepId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HizmetAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TalepTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anapanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.talepdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // anapanel
            // 
            this.anapanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.anapanel.Controls.Add(this.talepdataGridView);
            this.anapanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.anapanel.Location = new System.Drawing.Point(0, 0);
            this.anapanel.Name = "anapanel";
            this.anapanel.Size = new System.Drawing.Size(800, 450);
            this.anapanel.TabIndex = 1;
            // 
            // talepdataGridView
            // 
            this.talepdataGridView.AllowUserToAddRows = false;
            this.talepdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.talepdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.talepdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.talepdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TalepId,
            this.MusteriId,
            this.HizmetAdi,
            this.Aciklama,
            this.TalepTarihi,
            this.Durum});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.talepdataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.talepdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.talepdataGridView.Location = new System.Drawing.Point(0, 0);
            this.talepdataGridView.Name = "talepdataGridView";
            this.talepdataGridView.ReadOnly = true;
            this.talepdataGridView.RowHeadersVisible = false;
            this.talepdataGridView.RowHeadersWidth = 51;
            this.talepdataGridView.RowTemplate.Height = 24;
            this.talepdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.talepdataGridView.Size = new System.Drawing.Size(800, 450);
            this.talepdataGridView.TabIndex = 0;
            // 
            // TalepId
            // 
            this.TalepId.DataPropertyName = "TalepId";
            this.TalepId.HeaderText = "Talep No";
            this.TalepId.MinimumWidth = 6;
            this.TalepId.Name = "TalepId";
            this.TalepId.ReadOnly = true;
            this.TalepId.Width = 125;
            // 
            // MusteriId
            // 
            this.MusteriId.DataPropertyName = "MusteriId";
            this.MusteriId.HeaderText = "Müşteri";
            this.MusteriId.MinimumWidth = 6;
            this.MusteriId.Name = "MusteriId";
            this.MusteriId.ReadOnly = true;
            this.MusteriId.Width = 125;
            // 
            // HizmetAdi
            // 
            this.HizmetAdi.DataPropertyName = "HizmetAdi";
            this.HizmetAdi.HeaderText = "Hizmet";
            this.HizmetAdi.MinimumWidth = 6;
            this.HizmetAdi.Name = "HizmetAdi";
            this.HizmetAdi.ReadOnly = true;
            this.HizmetAdi.Width = 125;
            // 
            // Aciklama
            // 
            this.Aciklama.DataPropertyName = "Aciklama";
            this.Aciklama.HeaderText = "Açıklama";
            this.Aciklama.MinimumWidth = 6;
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.ReadOnly = true;
            this.Aciklama.Width = 125;
            // 
            // TalepTarihi
            // 
            this.TalepTarihi.DataPropertyName = "TalepTarihi";
            this.TalepTarihi.HeaderText = "Tarih";
            this.TalepTarihi.MinimumWidth = 6;
            this.TalepTarihi.Name = "TalepTarihi";
            this.TalepTarihi.ReadOnly = true;
            this.TalepTarihi.Width = 125;
            // 
            // Durum
            // 
            this.Durum.DataPropertyName = "Durum";
            this.Durum.HeaderText = "Durum";
            this.Durum.MinimumWidth = 6;
            this.Durum.Name = "Durum";
            this.Durum.ReadOnly = true;
            this.Durum.Width = 125;
            // 
            // TalepListeleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.anapanel);
            this.Name = "TalepListeleForm";
            this.Text = "TalepListeleForm";
            this.Load += new System.EventHandler(this.TalepListeleForm_Load);
            this.anapanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.talepdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel anapanel;
        private System.Windows.Forms.DataGridView talepdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TalepId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriId;
        private System.Windows.Forms.DataGridViewTextBoxColumn HizmetAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn TalepTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durum;
    }
}