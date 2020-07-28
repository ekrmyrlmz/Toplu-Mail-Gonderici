// Ekrem Yorulmaz
// ekrm.yorulmaz@gmail.com
// 
// ilk projem 
// Creation Date: 23.07.2020 19:10

using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace TopluMailGonderici
{
    public partial class Anaform1 : Form
    {
        public Anaform1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Eposta listesi aktarma
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListImport_Click(object sender, EventArgs e)
        {
            // 1- Pencere açılacak
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Text Dosyası |*.txt";
            file.ShowDialog();

            // 2- Açılan pencereden seçilen dosyanın yolu aktarılacak
            StreamReader mailList;
            mailList = File.OpenText(file.FileName);
            string email;
            while ((email = mailList.ReadLine()) != null)
            {
                // 3- Sadece mailleri ekle
                if (email.Contains("@") == true)
                {
                    // 4- Liste içinde aynı mail yoksa ekle
                    if (lstMails.Items.Contains(email) == false)
                    {
                        lstMails.Items.Add(email.ToString());
                    }
                }
            }
            mailList.Close();
        }


        /// <summary>
        /// Seçili eposta silme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectedEmailRemove_Click(object sender, EventArgs e)
        {
            lstMails.Items.Remove(lstMails.SelectedItem);
        }

        /// <summary>
        /// Tümünü silme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmailListClear_Click(object sender, EventArgs e)
        {
            lstMails.Items.Clear();
        }

        /// <summary>
        /// Mail Gönder
        /// </summary>
        /// <param name="sender"></param>
        private void btnMailSender_Click(object sender, EventArgs e)
        {
            // 1- Mail listesindeki adresleri döndürme
            foreach (var email in lstMails.Items)
            {
                // 2- Seçili adrese mail gönderme
                EmailSender(
                    email.ToString(),
                    tbxSubject.Text,
                    rtbxContents.Text
                    );



                MessageBox.Show(email.ToString());
            }
        }

        /// <summary>
        /// Mail gönderme fonksiyonu
        /// </summary>
        /// <param name="email"></param>
        /// <param name="subject"></param>
        /// <param name="content"></param>
        public void EmailSender(string email, string subject, string content)
        {
            try
            {

                SmtpClient smtp = new SmtpClient();
                smtp.Port = Convert.ToInt32(tbxPort.Text);
                smtp.Host = tbxIP.Text; //for gmail host  
                smtp.EnableSsl = checkSSL.Checked;
                smtp.Credentials = new NetworkCredential(tbxUser.Text, tbxPassword.Text);
                //smtp.UseDefaultCredentials = false;
                //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;


                MailMessage message = new MailMessage();
                message.From = new MailAddress(tbxUser.Text, "Test Mail");

                message.To.Add(new MailAddress(email));

                message.Subject = subject;
                message.IsBodyHtml = true;
                message.Body = content;
                smtp.Send(message);

                MessageBox.Show("Mail gönderildi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
