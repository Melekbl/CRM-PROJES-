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
namespace CRM.Proje1.UI
{
    public partial class PersonelForm : Form
    {
        private PersonelService personelService = new PersonelService();
        public PersonelForm()
        {
            InitializeComponent();
        }

        private void Personel_Load(object sender, EventArgs e)
        {
            Listele();
            UzmanlikDoldur();
        }
        private void Listele()
        {
            personellerdataGridView.DataSource = personelService.Listele();
        }
        private void UzmanlikDoldur()
        {
            uzmanlikcomboBox.Items.Clear();
            uzmanlikcomboBox.Items.Add("Ön Büro Şefi");
            uzmanlikcomboBox.Items.Add("Resepsiyonist");
            uzmanlikcomboBox.Items.Add("Gece Müdürü");
            uzmanlikcomboBox.Items.Add("Misafir İlişkileri");
            uzmanlikcomboBox.Items.Add("Bilgi İşlem Destek");
            uzmanlikcomboBox.Items.Add("Kat Hizmetleri Sorumlusu");
            uzmanlikcomboBox.Items.Add("Teknik Servis Uzmanı");
        }

        private void kaydetbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(adtextBox.Text) ||
                string.IsNullOrWhiteSpace(soyadtextBox.Text) ||
                uzmanlikcomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Tüm alanları doldurunuz");
                return;
            }

            Personel p = new Personel
            {
                AdSoyad = adtextBox.Text.Trim() + " " + soyadtextBox.Text.Trim(),
                Uzmanlik = uzmanlikcomboBox.SelectedItem.ToString()
            };

            personelService.Ekle(p);
            Listele();
            AlanlariTemizle();
        }

        private void silbutton_Click(object sender, EventArgs e)
        {
            if (personellerdataGridView.CurrentRow == null)
            {
                MessageBox.Show("Silinecek personeli seçiniz");
                return;
            }

            int id = Convert.ToInt32(
                personellerdataGridView.CurrentRow.Cells["PersonelId"].Value
            );

            var sonuc = MessageBox.Show(
                "Seçili personel silinsin mi?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (sonuc == DialogResult.Yes)
            {
                personelService.Sil(id);
                Listele();
                AlanlariTemizle();
            }
        }

        private void personellerdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = personellerdataGridView.Rows[e.RowIndex];

            string adSoyad = row.Cells["AdSoyad"].Value.ToString();
            var parca = adSoyad.Split(' ');

            adtextBox.Text = parca[0];
            soyadtextBox.Text = parca.Length > 1 ? parca[1] : "";
            uzmanlikcomboBox.SelectedItem = row.Cells["Uzmanlik"].Value.ToString();
        }
        private void AlanlariTemizle()
        {
           adtextBox.Clear();
            soyadtextBox.Clear();
            uzmanlikcomboBox.SelectedIndex = -1;
        }

        private void uzmanlikcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
