namespace CRM.Proje1.UI
{
    partial class DestekForm
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
            this.talepdataGridView = new System.Windows.Forms.DataGridView();
            this.statupanel = new System.Windows.Forms.Panel();
            this.kaydetbutton = new System.Windows.Forms.Button();
            this.memnuniyetcomboBox = new System.Windows.Forms.ComboBox();
            this.durumcomboBox = new System.Windows.Forms.ComboBox();
            this.guncellebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.talepdataGridView)).BeginInit();
            this.statupanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // talepdataGridView
            // 
            this.talepdataGridView.AllowUserToAddRows = false;
            this.talepdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.talepdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.talepdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.talepdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.talepdataGridView.Location = new System.Drawing.Point(0, 0);
            this.talepdataGridView.Name = "talepdataGridView";
            this.talepdataGridView.ReadOnly = true;
            this.talepdataGridView.RowHeadersWidth = 51;
            this.talepdataGridView.RowTemplate.Height = 24;
            this.talepdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.talepdataGridView.Size = new System.Drawing.Size(800, 450);
            this.talepdataGridView.TabIndex = 6;
            this.talepdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.talepdataGridView_CellContentClick_2);
            // 
            // statupanel
            // 
            this.statupanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.statupanel.Controls.Add(this.kaydetbutton);
            this.statupanel.Controls.Add(this.memnuniyetcomboBox);
            this.statupanel.Controls.Add(this.durumcomboBox);
            this.statupanel.Controls.Add(this.guncellebutton);
            this.statupanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statupanel.Location = new System.Drawing.Point(0, 194);
            this.statupanel.Name = "statupanel";
            this.statupanel.Size = new System.Drawing.Size(800, 256);
            this.statupanel.TabIndex = 7;
            this.statupanel.Paint += new System.Windows.Forms.PaintEventHandler(this.statupanel_Paint);
            // 
            // kaydetbutton
            // 
            this.kaydetbutton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.kaydetbutton.Enabled = false;
            this.kaydetbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kaydetbutton.Location = new System.Drawing.Point(499, 104);
            this.kaydetbutton.Name = "kaydetbutton";
            this.kaydetbutton.Size = new System.Drawing.Size(120, 50);
            this.kaydetbutton.TabIndex = 6;
            this.kaydetbutton.Text = "Kaydet";
            this.kaydetbutton.UseVisualStyleBackColor = false;
            this.kaydetbutton.Click += new System.EventHandler(this.kaydetbutton_Click);
            // 
            // memnuniyetcomboBox
            // 
            this.memnuniyetcomboBox.Enabled = false;
            this.memnuniyetcomboBox.FormattingEnabled = true;
            this.memnuniyetcomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.memnuniyetcomboBox.Location = new System.Drawing.Point(340, 104);
            this.memnuniyetcomboBox.Name = "memnuniyetcomboBox";
            this.memnuniyetcomboBox.Size = new System.Drawing.Size(139, 24);
            this.memnuniyetcomboBox.TabIndex = 5;
            this.memnuniyetcomboBox.Text = "Memnuniyet Puanı";
            // 
            // durumcomboBox
            // 
            this.durumcomboBox.FormattingEnabled = true;
            this.durumcomboBox.Items.AddRange(new object[] {
            "Açık",
            "Beklemede",
            "Tamamlandı"});
            this.durumcomboBox.Location = new System.Drawing.Point(42, 103);
            this.durumcomboBox.Name = "durumcomboBox";
            this.durumcomboBox.Size = new System.Drawing.Size(120, 24);
            this.durumcomboBox.TabIndex = 4;
            this.durumcomboBox.Text = "Durum";
            this.durumcomboBox.SelectedIndexChanged += new System.EventHandler(this.durumcomboBox_SelectedIndexChanged);
            // 
            // guncellebutton
            // 
            this.guncellebutton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.guncellebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncellebutton.Location = new System.Drawing.Point(169, 103);
            this.guncellebutton.Name = "guncellebutton";
            this.guncellebutton.Size = new System.Drawing.Size(120, 50);
            this.guncellebutton.TabIndex = 3;
            this.guncellebutton.Text = "Güncelle";
            this.guncellebutton.UseVisualStyleBackColor = false;
            this.guncellebutton.Click += new System.EventHandler(this.guncellebutton_Click);
            // 
            // DestekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statupanel);
            this.Controls.Add(this.talepdataGridView);
            this.Name = "DestekForm";
            this.Text = "DestekForm";
            this.Load += new System.EventHandler(this.DestekForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.talepdataGridView)).EndInit();
            this.statupanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView talepdataGridView;
        private System.Windows.Forms.Panel statupanel;
        private System.Windows.Forms.ComboBox durumcomboBox;
        private System.Windows.Forms.Button guncellebutton;
        private System.Windows.Forms.Button kaydetbutton;
        private System.Windows.Forms.ComboBox memnuniyetcomboBox;
    }
}