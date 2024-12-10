using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMIS_Dev_Branch
{
    public partial class FrmCertificationScreen : Form
    {
        public FrmCertificationScreen()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGenerateCertificate_Click(object sender, EventArgs e)
        {
            FrmBatchCertificatesScreen FrmBatchCertificatesScreen = new FrmBatchCertificatesScreen();
            FrmBatchCertificatesScreen.ShowDialog();
        }
    }
}
