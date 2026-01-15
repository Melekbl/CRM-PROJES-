using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM.Proje1.Service;
using CRM.Proje1.Domain;
using CRM.Proje1.DAL;

namespace CRM.Proje1.UI
{
    public partial class MusteriForm : Form
    {
        private MusteriService musteriService = new MusteriService();
        public MusteriForm()
        {
            InitializeComponent();
        }
        private void Temizle()
        {
            adtextBox1.Clear();

            epostatextBox4.Clear();
            telefontextBox3.Clear();

        }

        private void detaypanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Musteri_Load(object sender, EventArgs e)
        {

            Listele();
        }

        private void Listele()
        {
            dgvmüsteri.DataSource = musteriService.Listele();
        }

        private void yenimusterieklebutton_Click(object sender, EventArgs e)
        {
            string ad = adtextBox1.Text.Trim();


            if (string.IsNullOrEmpty(ad))
            {
                MessageBox.Show("Ad ve Soyad boş olamaz");
                return;
            }

            Musteri m = new Musteri
            {
                AdSoyad = ad,
                Email = epostatextBox4.Text.Trim(),
                Telefon = telefontextBox3.Text.Trim()
                // Adres DB'de yok → bilerek eklenmedi
            };

            musteriService.Ekle(m);

            Listele();
            Temizle();
        }

        private void adreslabel5_Click(object sender, EventArgs e)
        {

        }

        private void adrestextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvmüsteri_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvmüsteri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
            if (e.RowIndex < 0) return; // Başlığa tıklanırsa işlem yapma

            DataGridViewRow row = dgvmüsteri.Rows[e.RowIndex];

            // Personel formunda yaptığın gibi .Value.ToString() kullan
            adtextBox1.Text = row.Cells["AdSoyad"].Value.ToString();
            telefontextBox3.Text = row.Cells["Telefon"].Value.ToString();
            epostatextBox4.Text = row.Cells["Email"].Value.ToString();
        
    }
    }
    

}
