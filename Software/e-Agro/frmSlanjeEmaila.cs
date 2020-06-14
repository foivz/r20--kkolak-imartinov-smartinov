using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace e_Agro
{
    public partial class frmSlanjeEmaila : Form
    {
        MailMessage poruka;
        SmtpClient smtp;
        public frmSlanjeEmaila()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            smtp.SendAsyncCancel();
            MessageBox.Show("Slanje e-maila otkazano");
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            poruka = new MailMessage();
            poruka.To.Add(txtZa.Text);
            poruka.CC.Add(txtCC.Text);
            poruka.Subject = txtNaslov.Text;
            poruka.From = new MailAddress("aperic119@gmail.com");
            poruka.Body = rtxtSadrzaj.Text;
            if(lblPrivitak.Text.Length > 0)
            {
                if(System.IO.File.Exists(lblPrivitak.Text))
                {
                    poruka.Attachments.Add(new Attachment(lblPrivitak.Text));
                }
            }

            smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 25;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("aperic119@gmail.com", "agronom1234");
            smtp.SendAsync(poruka, poruka.Subject);
            smtp.SendCompleted += new SendCompletedEventHandler(smtp_SendCompleted);
        }

        private void smtp_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                MessageBox.Show("Slanje e-maila otkazano");
            }
            else if(e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                MessageBox.Show("Uspješno slanje e-maila");
            }
        }

        private void lnkDodajPrivitak_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(fdPrivitak.ShowDialog() != DialogResult.Cancel)
            {
                lblPrivitak.Text = fdPrivitak.FileName;
                lblPrivitak.Visible = true;
                lnkDodajPrivitak.Visible = false;
            }
        }
    }
}
