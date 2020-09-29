using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Web;
using System.IO;
//saldanha PINTAO

namespace frontPage
{
    public partial class frmCorrespondecia : Form
    {
        public frmCorrespondecia()
        {
            InitializeComponent();
        }
        SmtpClient smtp = new SmtpClient();
        MailMessage mail = new MailMessage();


        private void frmCorrespondecia_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("condoframe@gmail.com", "tcccondoframe");

            mail.From = new MailAddress("condoframe@gmail.com");
            if(!string.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                mail.To.Add(maskedTextBox1.Text);
            }
            else
            {
                MessageBox.Show("Campo Obrigatório");
                return;
            }
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                mail.CC.Add(textBox1.Text);
            }
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                mail.Bcc.Add(textBox2.Text);
            }
            mail.Subject = textBox3.Text;
            mail.Body = richTextBox1.Text;
            mail.IsBodyHtml = true;

            foreach (string file in listBox1.Items)
            {
                mail.Attachments.Add(new System.Net.Mail.Attachment(file));
            }

            smtp.Send(mail);
            MessageBox.Show("Email Enviado");
        }

        private void btnAnexos_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = true;
                if (dialog.ShowDialog() == DialogResult.OK) ;
                {
                    foreach (var file in dialog.FileName);
                    {
                        listBox1.Items.Add(file);
                    }
                }
            }
        }
    }
}
