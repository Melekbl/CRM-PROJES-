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
    public partial class HizmetForm : Form
    {
        HizmetService hizmetService = new HizmetService();
        public HizmetForm()
        {
            InitializeComponent();
        }

        private void Hizmet_Load(object sender, EventArgs e)
        {
            Listele();

        }
        private void Listele()
        {
            hizmetlerdataGridView.DataSource = null;
           hizmetlerdataGridView.DataSource = hizmetService.Listele();
        }

        private void kaydetbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(hizmetaditextBox.Text))
            {
                MessageBox.Show("Hizmet adı boş olamaz");
                return;
            }

            if (!decimal.TryParse(ucrettextBox.Text, out decimal ucret))
            {
                MessageBox.Show("Ücret geçerli bir sayı olmalı");
                return;
            }

            Hizmet h = new Hizmet
            {
                HizmetAdi = hizmetaditextBox.Text.Trim(),
                Aciklama = aciklamatextBox.Text.Trim(),
                Ucret = ucret
            };

            hizmetService.Ekle(h);
            Listele();
            Temizle();
        }

        private void silbutton_Click(object sender, EventArgs e)
        {
            if (hizmetlerdataGridView.CurrentRow == null)
                return;

            int hizmetId = Convert.ToInt32(
               hizmetlerdataGridView.CurrentRow.Cells["HizmetId"].Value
            );

            hizmetService.Sil(hizmetId);
            Listele();
        }
        private void Temizle()
        {
            hizmetaditextBox.Clear();
            aciklamatextBox.Clear();
            ucrettextBox.Clear();
        }

        private void hizmetlerdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            hizmetaditextBox.Text = hizmetlerdataGridView.Rows[e.RowIndex].Cells["HizmetAdi"].Value.ToString();
            aciklamatextBox.Text = hizmetlerdataGridView.Rows[e.RowIndex].Cells["Aciklama"].Value.ToString();
            ucrettextBox.Text = hizmetlerdataGridView.Rows[e.RowIndex].Cells["Ucret"].Value.ToString();
        }
    }
}
