namespace CRM.Proje1.UI
{
    partial class HizmetForm
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
            this.hizmetyonetimilabel = new System.Windows.Forms.Label();
            this.hizmetlerdataGridView = new System.Windows.Forms.DataGridView();
            this.silbutton = new System.Windows.Forms.Button();
            this.kaydetbutton = new System.Windows.Forms.Button();
            this.ucrettextBox = new System.Windows.Forms.TextBox();
            this.aciklamatextBox = new System.Windows.Forms.TextBox();
            this.hizmetaditextBox = new System.Windows.Forms.TextBox();
            this.ucretlabel = new System.Windows.Forms.Label();
            this.aciklamalabel = new System.Windows.Forms.Label();
            this.hizmetadilabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hizmetlerdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hizmetyonetimilabel
            // 
            this.hizmetyonetimilabel.AutoSize = true;
            this.hizmetyonetimilabel.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hizmetyonetimilabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.hizmetyonetimilabel.Location = new System.Drawing.Point(52, 28);
            this.hizmetyonetimilabel.Name = "hizmetyonetimilabel";
            this.hizmetyonetimilabel.Size = new System.Drawing.Size(145, 21);
            this.hizmetyonetimilabel.TabIndex = 19;
            this.hizmetyonetimilabel.Text = "HİZMET YÖNETİMİ";
            // 
            // hizmetlerdataGridView
            // 
            this.hizmetlerdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.hizmetlerdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.hizmetlerdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.hizmetlerdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hizmetlerdataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hizmetlerdataGridView.EnableHeadersVisualStyles = false;
            this.hizmetlerdataGridView.Location = new System.Drawing.Point(0, 285);
            this.hizmetlerdataGridView.Name = "hizmetlerdataGridView";
            this.hizmetlerdataGridView.ReadOnly = true;
            this.hizmetlerdataGridView.RowHeadersVisible = false;
            this.hizmetlerdataGridView.RowHeadersWidth = 51;
            this.hizmetlerdataGridView.RowTemplate.Height = 24;
            this.hizmetlerdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.hizmetlerdataGridView.Size = new System.Drawing.Size(675, 210);
            this.hizmetlerdataGridView.TabIndex = 18;
            this.hizmetlerdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hizmetlerdataGridView_CellContentClick);
            // 
            // silbutton
            // 
            this.silbutton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.silbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.silbutton.Location = new System.Drawing.Point(419, 82);
            this.silbutton.Name = "silbutton";
            this.silbutton.Size = new System.Drawing.Size(120, 50);
            this.silbutton.TabIndex = 17;
            this.silbutton.Text = "Sil";
            this.silbutton.UseVisualStyleBackColor = false;
            this.silbutton.Click += new System.EventHandler(this.silbutton_Click);
            // 
            // kaydetbutton
            // 
            this.kaydetbutton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.kaydetbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kaydetbutton.Location = new System.Drawing.Point(419, 176);
            this.kaydetbutton.Name = "kaydetbutton";
            this.kaydetbutton.Size = new System.Drawing.Size(120, 50);
            this.kaydetbutton.TabIndex = 16;
            this.kaydetbutton.Text = "Kaydet";
            this.kaydetbutton.UseVisualStyleBackColor = false;
            this.kaydetbutton.Click += new System.EventHandler(this.kaydetbutton_Click);
            // 
            // ucrettextBox
            // 
            this.ucrettextBox.Location = new System.Drawing.Point(207, 190);
            this.ucrettextBox.Multiline = true;
            this.ucrettextBox.Name = "ucrettextBox";
            this.ucrettextBox.Size = new System.Drawing.Size(149, 30);
            this.ucrettextBox.TabIndex = 15;
            // 
            // aciklamatextBox
            // 
            this.aciklamatextBox.Location = new System.Drawing.Point(207, 139);
            this.aciklamatextBox.Multiline = true;
            this.aciklamatextBox.Name = "aciklamatextBox";
            this.aciklamatextBox.Size = new System.Drawing.Size(149, 30);
            this.aciklamatextBox.TabIndex = 14;
            // 
            // hizmetaditextBox
            // 
            this.hizmetaditextBox.BackColor = System.Drawing.Color.White;
            this.hizmetaditextBox.Location = new System.Drawing.Point(207, 86);
            this.hizmetaditextBox.Multiline = true;
            this.hizmetaditextBox.Name = "hizmetaditextBox";
            this.hizmetaditextBox.Size = new System.Drawing.Size(149, 30);
            this.hizmetaditextBox.TabIndex = 13;
            // 
            // ucretlabel
            // 
            this.ucretlabel.AutoSize = true;
            this.ucretlabel.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ucretlabel.ForeColor = System.Drawing.Color.White;
            this.ucretlabel.Location = new System.Drawing.Point(52, 199);
            this.ucretlabel.Name = "ucretlabel";
            this.ucretlabel.Size = new System.Drawing.Size(61, 21);
            this.ucretlabel.TabIndex = 12;
            this.ucretlabel.Text = "ÜCRET";
            // 
            // aciklamalabel
            // 
            this.aciklamalabel.AutoSize = true;
            this.aciklamalabel.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aciklamalabel.ForeColor = System.Drawing.Color.White;
            this.aciklamalabel.Location = new System.Drawing.Point(52, 148);
            this.aciklamalabel.Name = "aciklamalabel";
            this.aciklamalabel.Size = new System.Drawing.Size(92, 21);
            this.aciklamalabel.TabIndex = 11;
            this.aciklamalabel.Text = "AÇIKLAMA";
            // 
            // hizmetadilabel
            // 
            this.hizmetadilabel.AutoSize = true;
            this.hizmetadilabel.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hizmetadilabel.ForeColor = System.Drawing.Color.White;
            this.hizmetadilabel.Location = new System.Drawing.Point(52, 95);
            this.hizmetadilabel.Name = "hizmetadilabel";
            this.hizmetadilabel.Size = new System.Drawing.Size(99, 21);
            this.hizmetadilabel.TabIndex = 10;
            this.hizmetadilabel.Text = "HİZMET ADI";
            // 
            // HizmetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(675, 495);
            this.Controls.Add(this.hizmetyonetimilabel);
            this.Controls.Add(this.hizmetlerdataGridView);
            this.Controls.Add(this.silbutton);
            this.Controls.Add(this.kaydetbutton);
            this.Controls.Add(this.ucrettextBox);
            this.Controls.Add(this.aciklamatextBox);
            this.Controls.Add(this.hizmetaditextBox);
            this.Controls.Add(this.ucretlabel);
            this.Controls.Add(this.aciklamalabel);
            this.Controls.Add(this.hizmetadilabel);
            this.Name = "HizmetForm";
            this.Text = "Hizmet";
            this.Load += new System.EventHandler(this.Hizmet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hizmetlerdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hizmetyonetimilabel;
        private System.Windows.Forms.DataGridView hizmetlerdataGridView;
        private System.Windows.Forms.Button silbutton;
        private System.Windows.Forms.Button kaydetbutton;
        private System.Windows.Forms.TextBox ucrettextBox;
        private System.Windows.Forms.TextBox aciklamatextBox;
        private System.Windows.Forms.TextBox hizmetaditextBox;
        private System.Windows.Forms.Label ucretlabel;
        private System.Windows.Forms.Label aciklamalabel;
        private System.Windows.Forms.Label hizmetadilabel;
    }
}