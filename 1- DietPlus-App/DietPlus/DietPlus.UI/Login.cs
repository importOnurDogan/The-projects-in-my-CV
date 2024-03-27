using DietPlus.Repositories;
using DietPlus.UI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietPlus.UI
{
    public partial class Login : Form
    {
        UserRepository userRepository = new UserRepository();
        public Login()
        {
            InitializeComponent();
        }
        int UserNameCount = 0;
        int PasswordCount = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            UserNameCount += 1;
            if (UserNameCount == 1)
            {
                txtEmail.Text = string.Empty;
            }

        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            PasswordCount += 1;
            if (PasswordCount == 1)
            {
                txtPassword.Text = string.Empty;
            }
        }

        private void pbPassword_Click(object sender, EventArgs e)
        {

            // Her tıklamada şifreyi göster veya gizle
            if (txtPassword.PasswordChar == '*')
            {
                // Şifreyi göster
                txtPassword.PasswordChar = '\0'; // '\0' karakteri şifre karakterini temsil eder.
            }
            else
            {
                // Şifreyi gizle
                txtPassword.PasswordChar = '*';
            }
        }
        private void lblSignIn_MouseEnter(object sender, EventArgs e)
        {
            // Label üzerine gelindiğinde fare imleci el işareti olsun
            lblSignIn.Cursor = Cursors.Hand;
            lblForgotPassword.Cursor = Cursors.Hand;
            lblAbout.Cursor = Cursors.Hand;
            btnSignIn.Cursor = Cursors.Hand;
            pbFacebook.Cursor = Cursors.Hand;
            pbTwitter.Cursor = Cursors.Hand;
            pbGoogle.Cursor = Cursors.Hand;
        }

        private void lblSignIn_MouseLeave(object sender, EventArgs e)
        {
            // Label üzerinden ayrılınca fare imleci normal olsun
            lblSignIn.Cursor = Cursors.Default;
            lblForgotPassword.Cursor = Cursors.Default;
            lblAbout.Cursor = Cursors.Default;
            btnSignIn.Cursor = Cursors.Default;
            pbFacebook.Cursor = Cursors.Default;
            pbTwitter.Cursor = Cursors.Default;
            pbGoogle.Cursor = Cursors.Default;
        }

        private void pbFacebook_Click(object sender, EventArgs e)
        {
            try
            {
                // Varsayılan web tarayıcısını kullanarak belirli bir URL'yi aç
                Process.Start(new ProcessStartInfo("https://www.facebook.com/") { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbTwitter_Click(object sender, EventArgs e)
        {
            try
            {
                // Varsayılan web tarayıcısını kullanarak belirli bir URL'yi aç
                Process.Start(new ProcessStartInfo("https://twitter.com/i/flow/login?input_flow_data=%7B%22requested_variant%22%3A%22eyJsYW5nIjoidHIifQ%3D%3D%22%7D") { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbGoogle_Click(object sender, EventArgs e)
        {
            try
            {
                // Varsayılan web tarayıcısını kullanarak belirli bir URL'yi aç
                Process.Start(new ProcessStartInfo("https://www.google.com/") { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblSignIn_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.ShowDialog();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            PasswordForget passwordForget = new PasswordForget();
            passwordForget.ShowDialog();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            PasswordValidator passwordValidator = new PasswordValidator();

            string password = txtPassword.Text;
            string email = txtEmail.Text;
            string errorMessage;

            if (passwordValidator.IsPasswordValid(password, email, out errorMessage))
            {
                if (userRepository.AuthenticateUser(email, password))
                {
                    var result = userRepository.Find(x => x.Email == email);
                    HomePage homePage = new HomePage();
                    homePage.UserInformation(result.Id);
                    homePage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hata oluştu: " + "Email veya Şifre Hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Geçersiz şifre: {errorMessage}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void lblAbout_Click(object sender, EventArgs e)
        {
            WhoAreWe whoAreWe = new WhoAreWe();
            whoAreWe.ShowDialog();
            
        }
    }
}