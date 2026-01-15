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

    public partial class YeniKullaniciForm : Form
    {
        private KullaniciService kullaniciService = new KullaniciService();
        public YeniKullaniciForm()
        {
            InitializeComponent();
        }

        private void YeniKullaniciForm_Load(object sender, EventArgs e)
        {

        }

        private void kaydetbutton_Click(object sender, EventArgs e)
        {
            if (kullaniciaditextBox.Text == "" || sifretextBox.Text == "" || rolcomboBox.SelectedItem == null)
            {
                MessageBox.Show("Tüm alanları doldurun");
                return;
            }

              kullaniciService.KullaniciEkle(
                kullaniciaditextBox.Text,
                sifretextBox.Text,
                rolcomboBox.SelectedItem.ToString()
            );

            MessageBox.Show("Kullanıcı oluşturuldu");
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rolcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
