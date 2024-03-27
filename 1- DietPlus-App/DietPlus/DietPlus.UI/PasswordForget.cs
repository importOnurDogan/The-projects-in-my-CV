using DietPlus.Repositories;
using DietPlus.UI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace DietPlus.UI
{
    public partial class PasswordForget : Form
    {
        UserRepository userRepository = new UserRepository();
        public PasswordForget()
        {
            InitializeComponent();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {  
            this.Hide();
        }

        private void SifremiUnuttum_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Form kapatıldığında uygulamayı da kapatın
           
        }

        private void btnSendEmail_MouseEnter(object sender, EventArgs e)
        {
            // Label üzerine gelindiğinde fare imleci el işareti olsun
            pbBack.Cursor = Cursors.Hand;
        }

        private void btnSendEmail_MouseLeave(object sender, EventArgs e)
        {

            pbBack.Cursor = Cursors.Default;
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            string userEmail = txtEmail.Text;
            EmailSenderApp emailSenderApp = new EmailSenderApp();
            // Email var mı kontrolü
            if (userRepository.IsEmailExists(userEmail))
            {
                var user = userRepository.GetAll().FirstOrDefault(x => x.Email == userEmail);

                if (user != null)
                {
                    // Kullanıcıya bir şifre sıfırlama bağlantısı içeren e-posta gönder
                    emailSenderApp.SendEmail(userEmail, user.Password);
                    MessageBox.Show("Şifreniz e-postanıza gönderildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bu e-posta adresi sistemimizde kayıtlı değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
