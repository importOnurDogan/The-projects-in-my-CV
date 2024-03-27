using DietPlus.Core.Enum;
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
    public partial class CreateAccount : Form
    {
        UserRepository userRepository = new UserRepository();
        public CreateAccount()
        {
            InitializeComponent();
        }
        private void CreateAccount_Load(object sender, EventArgs e)
        {
            cmbGender.DataSource = Enum.GetValues(typeof(Gender));
            cmbWeightStatus.DataSource = Enum.GetValues(typeof(WeightStatus));
        }
        private void pbBack_MouseLeave(object sender, EventArgs e)
        {
            // Label üzerinden ayrılınca fare imleci normal olsun
            pbBack.Cursor = Cursors.Default;
        }

        private void pbBack_MouseEnter(object sender, EventArgs e)
        {
            // Label üzerine gelindiğinde fare imleci el işareti olsun
            pbBack.Cursor = Cursors.Hand;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pbSifre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("* Şifre en az 8 karakterli olmalıdır\n" +
                "* Şifre en az bir özel karakter içermelidir.\n" +
                "* Şifre en az bir büyük harf içermelidir\n" +
                "* Şifre en az bir sayı içermelidir",
                "Doğru Şifre Koyma Kuralları", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HesapOlustur_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Form kapatıldığında uygulamayı da kapatın
           
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            PasswordValidator passwordValidator = new PasswordValidator();

            try
            {
                string password = txtPassword.Text;
                string password2 = txtPaswordAgain.Text;
                string email = txtEmail.Text;
                string userName = txtNameSurname.Text;
                double height = Convert.ToDouble(txtHeight.Text);
                double weight = Convert.ToDouble(txtWeight.Text);
                // Seçilen cinsiyeti almak için
                Gender selectedGender = (Gender)cmbGender.SelectedItem;
                WeightStatus selectedWeightStatus = (WeightStatus)cmbWeightStatus.SelectedItem;

                DateTime selectedDate = dtpBithDate.Value;
                string errorMessage;
                if (userRepository.AuthenticateUserForCreaate(txtEmail.Text))
                {
                    if (passwordValidator.IsPasswordValid(password, email, out errorMessage))
                    {
                        if (passwordValidator.AreStringsEqual(password, password2))
                        {
                            userRepository.CreateNewAccount(email, userName, password, height, weight, selectedGender, selectedWeightStatus, selectedDate);

                            MessageBox.Show("Kayıt Başarılıyla Gerçekleşti.Login Sayfasına Yönlendiriliyorsunuz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Login login = new Login();
                            login.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Şifre Aynı Değil.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }

                    else
                    {
                        MessageBox.Show($"Geçersiz şifre: {errorMessage}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Hata oluştu: " + "Email Başka bir Kuulanıcıya ait", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata oluştu: " + "Eksik Alanları Doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
    }
}
