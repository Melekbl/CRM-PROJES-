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
    public partial class TalepListeleForm : Form
    {
        private TalepService talepService;
        public TalepListeleForm()
        {
            InitializeComponent();
            talepService = new TalepService();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TalepListeleForm_Load(object sender, EventArgs e)
        {
            talepdataGridView.AutoGenerateColumns = false;
            talepdataGridView.DataSource = talepService.TalepListele();
        }
    }
}
