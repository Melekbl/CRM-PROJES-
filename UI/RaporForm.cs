using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CRM.Proje1.DAL;
using CRM.Proje1.Domain;
using CRM.Proje1.Service;

namespace CRM.Proje1.UI
{
    public partial class RaporForm : Form
    {
        TalepService talepService = new TalepService();
        public RaporForm()
        {
            InitializeComponent();
        }

        private void ozetlabel_Click(object sender, EventArgs e)
        {

        }

        private void ustpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void RaporForm_Load(object sender, EventArgs e)
        {
            

        }
        private void ChartHazirla()
        {
            raporchart.Series.Clear();
            raporchart.ChartAreas.Clear();

            ChartArea alan = new ChartArea();
            alan.AxisX.Interval = 1;
            alan.AxisX.MajorGrid.Enabled = false;
            alan.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            raporchart.ChartAreas.Add(alan);
        }

        private void raporgetirbutton_Click(object sender, EventArgs e)
        {

            if (raporcomboBox.SelectedItem == null) return;

            string secim = raporcomboBox.SelectedItem.ToString();

            // HER RAPOR ÖNCESİ TEK SEFER TEMİZLE
            raporchart.Series.Clear();
            raporchart.ChartAreas.Clear();
            ozetlabel.Visible = false;
            rapordataGridView.DataSource = null;

            // Chart alanını hazırla
            ChartArea alan = new ChartArea();
            alan.AxisX.Interval = 1;
            raporchart.ChartAreas.Add(alan);

            // 1️⃣ Talep Türüne Göre Hizmet Yoğunluğu (GRAFİK + TABLO)
            if (secim == "Talep Türüne Göre Hizmet Yoğunluğu")
            {
                var data = talepService.HizmetYogunluguGetir();
                rapordataGridView.DataSource = data;

                var seri = raporchart.Series.Add("Hizmet Yoğunluğu");
                seri.ChartType = SeriesChartType.Column;
                seri.IsValueShownAsLabel = true;

                foreach (var item in data)
                {
                    seri.Points.AddXY(item.Ad, item.Sayi);
                }
            }

            // 2️⃣ Ortalama Çözüm Süresi (SADECE YAZI)
            // 2️⃣ Ortalama Çözüm Süresi (SADECE YAZI)
            else if (secim == "Ortalama Çözüm Süresi")
            {
                double gun = talepService.OrtalamaCozumSuresiGetir();

                rapordataGridView.DataSource = new List<object>
    {
        new
        {
            Aciklama = "Ortalama Çözüm Süresi (Gün)",
            Deger = gun.ToString("0.00")
        }
    };

                if (gun > 0)
                {
                    ozetlabel.Text = $"Ortalama çözüm süresi: {gun:0.00} gün";
                }
                else
                {
                    ozetlabel.Text = "Henüz tamamlanan talep bulunmamaktadır.";
                }

                ozetlabel.Visible = true;
            }


            // 3️⃣ Personel Performans Raporu (GRAFİK)
            else if (secim == "Personel Performans Raporu")
            {
                var data = talepService.PersonelPerformansGetir();

                // ✅ TABLO
                rapordataGridView.DataSource = data
                    .Select(x => new
                    {
                        Personel = x.Item1,
                        CozulenTalep = x.Item2
                    }).ToList();

                int toplamTalep = data.Sum(x => x.Item2);

                var seri = raporchart.Series.Add("Personel Performansı");
                seri.ChartType = SeriesChartType.Column;
                seri.IsValueShownAsLabel = true;

                raporchart.ChartAreas[0].AxisX.Interval = 1;
                raporchart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

                string enIyiPersonel = "";
                int maxTalep = 0;

                foreach (var item in data)
                {
                    seri.Points.AddXY(item.Item1, item.Item2);

                    if (item.Item2 > maxTalep)
                    {
                        maxTalep = item.Item2;
                        enIyiPersonel = item.Item1;
                    }
                }

                ozetlabel.Text =
                    $"🏆 En iyi personel: {enIyiPersonel}\n" +
                    $"📊 Toplam çözülen talep: {toplamTalep}";
                ozetlabel.Visible = true;
            }

            // 4️⃣ Müşteri Bazlı Talep Raporu (GRAFİK)
            else if (secim == "Müşteri Bazlı Talep Raporu")
            {
                var data = talepService.MusteriBazliTalepRaporu();

                // ✅ TABLO
                rapordataGridView.DataSource = data
                    .Select(x => new
                    {
                        Musteri = x.Item1,
                        TalepSayisi = x.Item2
                    }).ToList();

                var seri = raporchart.Series.Add("Müşteri Bazlı Talepler");
                seri.ChartType = SeriesChartType.Column;
                seri.IsValueShownAsLabel = true;

                foreach (var item in data)
                {
                    seri.Points.AddXY(item.Item1, item.Item2);
                }
            }
            // 5️⃣ Müşteri Memnuniyet Raporu (GRAFİK)
            else if (secim == "Müşteri Memnuniyet Raporu")
            {
                var data = talepService.MusteriMemnuniyetRaporuGetir();

                // ✅ TABLO
                rapordataGridView.DataSource = data
                    .Select(x => new
                    {
                        Musteri = x.Item1,
                        MemnuniyetPuani = x.Item2
                    }).ToList();

                var seri = raporchart.Series.Add("Müşteri Memnuniyeti");
                seri.ChartType = SeriesChartType.Column;
                seri.IsValueShownAsLabel = true;

                foreach (var item in data)
                {
                    seri.Points.AddXY(item.Item1, item.Item2);
                }
            }

        }
            

      

         
        


        private void raporcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rapordataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

        
    
}
