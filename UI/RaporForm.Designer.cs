namespace CRM.Proje1.UI
{
    partial class RaporForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.ustpanel = new System.Windows.Forms.Panel();
            this.raporlabel = new System.Windows.Forms.Label();
            this.raporcomboBox = new System.Windows.Forms.ComboBox();
            this.raporgetirbutton = new System.Windows.Forms.Button();
            this.ozetlabel = new System.Windows.Forms.Label();
            this.rapordataGridView = new System.Windows.Forms.DataGridView();
            this.raporchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ustpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rapordataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raporchart)).BeginInit();
            this.SuspendLayout();
            // 
            // ustpanel
            // 
            this.ustpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ustpanel.Controls.Add(this.raporlabel);
            this.ustpanel.Controls.Add(this.raporcomboBox);
            this.ustpanel.Controls.Add(this.raporgetirbutton);
            this.ustpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ustpanel.Location = new System.Drawing.Point(0, 0);
            this.ustpanel.Name = "ustpanel";
            this.ustpanel.Size = new System.Drawing.Size(680, 136);
            this.ustpanel.TabIndex = 5;
            this.ustpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ustpanel_Paint);
            // 
            // raporlabel
            // 
            this.raporlabel.AutoSize = true;
            this.raporlabel.BackColor = System.Drawing.Color.Black;
            this.raporlabel.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.raporlabel.ForeColor = System.Drawing.Color.White;
            this.raporlabel.Location = new System.Drawing.Point(3, 37);
            this.raporlabel.Name = "raporlabel";
            this.raporlabel.Size = new System.Drawing.Size(111, 21);
            this.raporlabel.TabIndex = 0;
            this.raporlabel.Text = "RAPOR TÜRÜ";
            // 
            // raporcomboBox
            // 
            this.raporcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.raporcomboBox.FormattingEnabled = true;
            this.raporcomboBox.Items.AddRange(new object[] {
            "Talep Türüne Göre Hizmet Yoğunluğu",
            "Ortalama Çözüm Süresi",
            "Personel Performans Raporu",
            "Müşteri Bazlı Talep Raporu",
            "Müşteri Memnuniyet Raporu"});
            this.raporcomboBox.Location = new System.Drawing.Point(120, 34);
            this.raporcomboBox.Name = "raporcomboBox";
            this.raporcomboBox.Size = new System.Drawing.Size(125, 24);
            this.raporcomboBox.TabIndex = 1;
            this.raporcomboBox.SelectedIndexChanged += new System.EventHandler(this.raporcomboBox_SelectedIndexChanged);
            // 
            // raporgetirbutton
            // 
            this.raporgetirbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.raporgetirbutton.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raporgetirbutton.Location = new System.Drawing.Point(317, 20);
            this.raporgetirbutton.Name = "raporgetirbutton";
            this.raporgetirbutton.Size = new System.Drawing.Size(121, 59);
            this.raporgetirbutton.TabIndex = 2;
            this.raporgetirbutton.Text = "Rapor Getir";
            this.raporgetirbutton.UseVisualStyleBackColor = false;
            this.raporgetirbutton.Click += new System.EventHandler(this.raporgetirbutton_Click);
            // 
            // ozetlabel
            // 
            this.ozetlabel.AutoSize = true;
            this.ozetlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ozetlabel.Location = new System.Drawing.Point(25, 322);
            this.ozetlabel.Name = "ozetlabel";
            this.ozetlabel.Size = new System.Drawing.Size(64, 25);
            this.ozetlabel.TabIndex = 4;
            this.ozetlabel.Text = "label1";
            this.ozetlabel.Visible = false;
            this.ozetlabel.Click += new System.EventHandler(this.ozetlabel_Click);
            // 
            // rapordataGridView
            // 
            this.rapordataGridView.AllowUserToAddRows = false;
            this.rapordataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rapordataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rapordataGridView.Location = new System.Drawing.Point(0, 136);
            this.rapordataGridView.Name = "rapordataGridView";
            this.rapordataGridView.ReadOnly = true;
            this.rapordataGridView.RowHeadersWidth = 51;
            this.rapordataGridView.RowTemplate.Height = 24;
            this.rapordataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rapordataGridView.Size = new System.Drawing.Size(680, 183);
            this.rapordataGridView.TabIndex = 6;
            this.rapordataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rapordataGridView_CellContentClick);
            // 
            // raporchart
            // 
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.raporchart.ChartAreas.Add(chartArea1);
            this.raporchart.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.raporchart.Legends.Add(legend1);
            this.raporchart.Location = new System.Drawing.Point(0, 311);
            this.raporchart.Name = "raporchart";
            this.raporchart.Size = new System.Drawing.Size(680, 201);
            this.raporchart.TabIndex = 7;
            this.raporchart.Text = "chart1";
            this.raporchart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // RaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 512);
            this.Controls.Add(this.ozetlabel);
            this.Controls.Add(this.raporchart);
            this.Controls.Add(this.rapordataGridView);
            this.Controls.Add(this.ustpanel);
            this.Name = "RaporForm";
            this.Text = "RaporForm";
            this.Load += new System.EventHandler(this.RaporForm_Load);
            this.ustpanel.ResumeLayout(false);
            this.ustpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rapordataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raporchart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ustpanel;
        private System.Windows.Forms.Label ozetlabel;
        private System.Windows.Forms.Label raporlabel;
        private System.Windows.Forms.ComboBox raporcomboBox;
        private System.Windows.Forms.Button raporgetirbutton;
        private System.Windows.Forms.DataGridView rapordataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart raporchart;
    }
}