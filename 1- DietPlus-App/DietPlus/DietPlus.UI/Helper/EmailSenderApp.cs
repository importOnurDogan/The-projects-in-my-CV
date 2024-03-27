using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DietPlus.UI.Helper
{
    public class EmailSenderApp
    {
        public void SendEmail(string toEmail, string password)
        {
            ///diet4180@gmail.com", "Diet.2545  //uygulama şifresi lqlr bndg jujl dlyf
            string fromEmail = "diet4180@gmail.com";

            // SMTP ayarları
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587; // SMTP port numarası
            smtpClient.Credentials = new NetworkCredential("diet4180@gmail.com", "lqlrbndgjujldlyf");
            smtpClient.EnableSsl = true;

            // E-posta oluşturma
            MailMessage mailMessage = new MailMessage(fromEmail, toEmail, "Şifre Bilgilendirme", $"Şifreniz: {password}");
            mailMessage.IsBodyHtml = false; // Eğer HTML içerik kullanacaksanız true yapabilirsiniz.

            try
            {
                // E-postayı gönderme
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("E-posta gönderirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Kaynakları temizleme
                mailMessage.Dispose();
                smtpClient.Dispose();
            }
        }

    }

}
