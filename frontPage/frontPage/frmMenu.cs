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

        private void MenuPage_Click(object sender, EventArgs e)
        {

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
            frmPortaria newfuncao1 = new frmPortaria();
            newfuncao1.ShowDialog();
        }

        private void btnSeg_Click(object sender, EventArgs e)
        {
            frmCorrespondecia newfuncao2 = new frmCorrespondecia();
            newfuncao2.ShowDialog();
        }

        private void btnTerc_Click(object sender, EventArgs e)
        {
            frmMensagens newfuncao3 = new frmMensagens();
            newfuncao3.ShowDialog();
        }

        private void btnQua_Click(object sender, EventArgs e)
        {
            frmReservas newfuncao4 = new frmReservas();
            newfuncao4.ShowDialog();
        }
    }
}
