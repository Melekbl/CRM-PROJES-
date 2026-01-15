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

namespace CRM.Proje1.UI
{
    public partial class SifremiUnuttum : Form
    {
        private KullaniciService kullaniciService = new KullaniciService();
        public SifremiUnuttum()
        {
            InitializeComponent();
        }

        private void guncellebutton_Click(object sender, EventArgs e)
        {
            if (kullaniciaditextBox.Text == "" || yenisifretextBox.Text == "")
            {
                MessageBox.Show("Alanları doldurun");
                return;
            }

            bool sonuc = kullaniciService.SifreGuncelle(
                kullaniciaditextBox.Text,
                yenisifretextBox.Text
            );

            if (sonuc)
            {
                MessageBox.Show("Şifre güncellendi");
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı");
            }
        }

        private void SifremiUnuttum_Load(object sender, EventArgs e)
        {

        }
    }
}
