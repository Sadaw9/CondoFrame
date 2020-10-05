using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontPage
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Today.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnPri_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSeg_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTerc_Click(object sender, EventArgs e)
        {
        
        }
        private void condôminosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCondomino newfuncao5 = new frmCondomino();
            newfuncao5.ShowDialog();
        }

        private void mCadastro_Click(object sender, EventArgs e)
        {

        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservas newfuncao4 = new frmReservas();
            newfuncao4.ShowDialog();
        }

        private void sindicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSindico newfuncao6 = new frmSindico();
            newfuncao6.ShowDialog();
        }

        private void correspondênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCorrespondecia newfuncao2 = new frmCorrespondecia();
            newfuncao2.ShowDialog();
        }

        private void reclamaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReclamacao newfuncao1 = new frmReclamacao();
            newfuncao1.ShowDialog();
        }
    }
}
