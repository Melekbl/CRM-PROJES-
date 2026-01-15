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
    public partial class DestekForm : Form
    {
        TalepService talepService = new TalepService();
        public DestekForm()
        {
            InitializeComponent();
        }

        private void talepdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void talepdataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DestekForm_Load(object sender, EventArgs e)
        {
            Listele();
            DurumDoldur();
        }
        private void Listele()
        {
            talepdataGridView.DataSource = talepService.Listele();
        }
        private void DurumDoldur()
        {
            durumcomboBox.Items.Clear();
            durumcomboBox.Items.Add("Acik");
            durumcomboBox.Items.Add("Beklemede");
            durumcomboBox.Items.Add("Tamamlandı");
            durumcomboBox.SelectedIndex = 0;
        }

        private void talepdataGridView_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            durumcomboBox.Text = talepdataGridView.Rows[e.RowIndex]
                .Cells["Durum"].Value.ToString();
            if (talepdataGridView.CurrentRow == null) return;

            string durum = talepdataGridView.CurrentRow.Cells["Durum"].Value.ToString();

            bool tamamlandi = durum == "Tamamlandı";

            memnuniyetcomboBox.Enabled = tamamlandi;
            kaydetbutton.Enabled = tamamlandi;
        }

        private void guncellebutton_Click(object sender, EventArgs e)
        {
            if (talepdataGridView.CurrentRow == null)
            {
                MessageBox.Show("Talep seçiniz.");
                return;
            }

            int talepId = Convert.ToInt32(
                talepdataGridView.CurrentRow.Cells["TalepId"].Value
            );

            string durum = durumcomboBox.Text;

            talepService.DurumGuncelle(talepId, durum);

            MessageBox.Show("Talep durumu güncellendi.");
            Listele();
        }

        private void statupanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void TalepleriYukle()
        {
            talepdataGridView.DataSource = talepService.TalepListele();
        }
        private void kaydetbutton_Click(object sender, EventArgs e)
        {
            if (memnuniyetcomboBox.SelectedItem == null)
            {
                MessageBox.Show("Memnuniyet puanı seçiniz");
                return;
            }

            int puan = Convert.ToInt32(memnuniyetcomboBox.SelectedItem);
            int talepId = Convert.ToInt32(
                talepdataGridView.CurrentRow.Cells["TalepId"].Value
            );

           

            MessageBox.Show("Memnuniyet kaydedildi");

            TalepleriYukle(); // grid yenile
        }

        private void durumcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
