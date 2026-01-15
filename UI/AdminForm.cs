using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.Proje1.UI
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            menupanel.BringToFront(); // menü HER ZAMAN üstte
           panelmain.SendToBack();      // içerik arkada ama görünür

        }
     
        private void FormYukle(Form frm)
        {
                  // Önceki formu sil
            frm.TopLevel = false;             // Formu gömülebilir yap
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelmain.Controls.Add(frm);
            frm.BringToFront();
            panelmain.Tag = frm;
            frm.Show();
        }

        private void musteributton_Click(object sender, EventArgs e)
        {

            MusteriForm mf = new MusteriForm();
            FormYukle(mf);
        }

        private void hizmetbutton_Click(object sender, EventArgs e)
        {
            FormYukle(new HizmetForm());
        }

        private void personelbutton_Click(object sender, EventArgs e)
        {
            FormYukle(new PersonelForm());
        }

        private void talepbutton_Click(object sender, EventArgs e)
        {
            FormYukle(new TalepListeleForm());

        }

        private void raporbutton_Click(object sender, EventArgs e)
        {
            FormYukle(new RaporForm());
        }

        private void cıkısbutton_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is LoginForm)
                {
                    form.Show();
                    break;
                }
            }

            this.Close(); // SADECE bu form kapanır
        }
    }
}
