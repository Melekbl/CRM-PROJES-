using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM.Proje1.Domain;
using CRM.Proje1.Service;

namespace CRM.Proje1.UI
{
    public partial class CagriForm : Form
    {
        MusteriService musteriService = new MusteriService();
        HizmetService hizmetService = new HizmetService();
        PersonelService personelService = new PersonelService();
        TalepService talepService = new TalepService();
        public CagriForm()
        {
            InitializeComponent();
        }

        private void CagrıForm_Load(object sender, EventArgs e)
        {
            MusteriDoldur();
            HizmetDoldur();
            PersonelDoldur();
        }
        private void MusteriDoldur()
        {
            mustericomboBox.DisplayMember = "AdSoyad";
            mustericomboBox.ValueMember = "MusteriId";
            mustericomboBox.DataSource = musteriService.Listele();
            mustericomboBox.SelectedIndex = -1;
        }
        private void HizmetDoldur()
        {
            hizmetcomboBox.DisplayMember = "HizmetAdi";
            hizmetcomboBox.ValueMember = "HizmetId";
            hizmetcomboBox.DataSource = hizmetService.Listele();
            hizmetcomboBox.SelectedIndex = -1;
        }
        private void PersonelDoldur()
        {
            personelcomboBox.DisplayMember = "AdSoyad";
            personelcomboBox.ValueMember = "PersonelId";
            personelcomboBox.DataSource = personelService.Listele();
            personelcomboBox.SelectedIndex = -1;
        }

        private void talepolusturbutton_Click(object sender, EventArgs e)
        {
            if (mustericomboBox.SelectedIndex == -1 ||
        personelcomboBox.SelectedIndex == -1 ||
        personelcomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Müşteri, Hizmet ve Personel seçiniz.");
                return;
            }

            if (string.IsNullOrWhiteSpace(aciklamatextBox.Text))
            {
                MessageBox.Show("Açıklama boş olamaz.");
                return;
            }

            Talep t = new Talep
            {
                MusteriId = (int)mustericomboBox.SelectedValue,
                HizmetId = (int)personelcomboBox.SelectedValue,
                PersonelId = (int)personelcomboBox.SelectedValue,
                Aciklama = aciklamatextBox.Text.Trim()
            };

            talepService.TalepOlustur(t);

            MessageBox.Show("Talep oluşturuldu.");
            aciklamatextBox.Clear();
        }
    }
}
