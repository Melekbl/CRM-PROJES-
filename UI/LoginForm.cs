using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM.Proje1.Domain;
using CRM.Proje1.Service;
using CRM.Proje1.UI;
using System.Runtime.InteropServices;

namespace CRM.Proje1
{
    public partial class LoginForm : Form
    {
       

[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn
(
    int nLeftRect,
    int nTopRect,
    int nRightRect,
    int nBottomRect,
    int nWidthEllipse,
    int nHeightEllipse
);
    private KullaniciService kullaniciService = new KullaniciService();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void rolcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void girisbutton_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text.Trim();
            string sifre = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz");
                return;
            }

            Kullanici kullanici = kullaniciService.Giris(kullaniciAdi, sifre);

            if (kullanici == null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                return;
            }

            // 🔐 ROL KONTROLÜ
            Form acilacakForm = null;

            switch (kullanici.Rol)
            {
                case "Admin":
                    acilacakForm = new AdminForm();
                    break;

                case "Çağrı Personeli":
                    acilacakForm = new CagriForm();
                    break;

                case "Destek Personeli":
                    acilacakForm = new DestekForm();
                    break;

                default:
                    MessageBox.Show("Yetkisiz kullanıcı rolü");
                    return;
            }

            // Login ekranını gizle, yeni formu aç
            this.Hide();
           
            acilacakForm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            panel1.Region = Region.FromHrgn(
        CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 25, 25)
    );
        }

        private void sifremiunuttumbutton_Click(object sender, EventArgs e)
        {
            var frm = new SifremiUnuttum();
            frm.ShowDialog();

        }

        private void yenikullaniciolusturbutton_Click(object sender, EventArgs e)
        {
            var frm = new YeniKullaniciForm();
            frm.ShowDialog(); // Login açık kalsın
        }

        private void loginpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kullaniciadilabel_Click(object sender, EventArgs e)
        {

        }

        private void piclogo_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
