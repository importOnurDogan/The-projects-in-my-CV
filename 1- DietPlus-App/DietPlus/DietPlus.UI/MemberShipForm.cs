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

namespace DietPlus.UI
{
    public partial class MemberShipForm : Form
    {
        public MemberShipForm()
        {
            InitializeComponent();
        }
        UserRepository userRepository = new UserRepository();
        UserDetailRepository userDetailRepository = new UserDetailRepository();
        int _userId = 2;

        private void MemberShipForm_Load(object sender, EventArgs e)
        {



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
            Login login = new Login();
            login.Show();
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
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PasswordValidator passwordValidator = new PasswordValidator();
            var user = userRepository.Find(x => x.Id == _userId);
            var userDetail = userDetailRepository.Find(x => x.UserId == _userId);

            user.Password = txtPassword.Text;
            userDetail.Height = Convert.ToDouble(txtHeight.Text);
            userDetail.Weight = Convert.ToDouble(txtWeight.Text);
            userDetail.WeightStatus = (WeightStatus)cmbWeightStatus.SelectedItem;
            string errorMessage;

            if (passwordValidator.IsPasswordValid(txtPassword.Text, "mrtyydm@gmail.com", out errorMessage))
            {

                userRepository.UpdateAccount(user, userDetail);

                MessageBox.Show("Güncelleme Başarılıyla Gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
            }

            else
            {
                MessageBox.Show($"Geçersiz şifre: {errorMessage}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UserInformation(int userID)
        {
            _userId = userID;

            var user = userRepository.Find(x => x.Id == userID);
            var userDetail = userDetailRepository.Find(x => x.UserId == userID);


            txtHeight.Text = userDetail.Height.ToString();
            txtWeight.Text = userDetail.Weight.ToString();
            txtPassword.Text = user.Password.ToString();

            // ComboBox'u WeightStatus enum ile doldur
            cmbWeightStatus.DataSource = Enum.GetValues(typeof(WeightStatus));

            // Kullanıcının ağırlık durumunu seçili olarak belirle
            cmbWeightStatus.SelectedItem = userDetail.WeightStatus;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var user = userRepository.Find(x => x.Id == _userId);
            var userDetail = userDetailRepository.Find(x => x.UserId == _userId);

            userRepository.DeleteAccount(user, userDetail);
        }
    }
}