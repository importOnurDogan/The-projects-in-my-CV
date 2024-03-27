using DietPlus.Core.Enum;
using DietPlus.Entities;
using DietPlus.Repositories;
using DietPlus.UI.Properties;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.DataFormats;

namespace DietPlus.UI
{
    public partial class HomePage : Form
    {
        FoodRepository foodRepository = new FoodRepository();
        MealRepository mealRepository = new MealRepository();
        UserRepository userRepository = new UserRepository();
        MealFoodRelationRepository mealFoodRepository = new MealFoodRelationRepository();
        UserDetailRepository userDetailRepository = new UserDetailRepository();
        int _userId = 2;
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            GetFiilFood();
            timer1.Start();

        }
        public void GetFiilFood()
        {
            PopulateMealData(dtpDateTime.Value, _userId, mealRepository, dataGridView1, lblBrProt, lblBrKarb, lblBrFat, lblBrCal, MealName.BrakFast);

            PopulateMealData(dtpDateTime.Value, _userId, mealRepository, dataGridView2, lblLnProt, lblLnKarb, lblLnFat, lblLnCal, MealName.Lunch);

            PopulateMealData(dtpDateTime.Value, _userId, mealRepository, dataGridView3, lblDnProt, lblDnCar, lblDnFat, lblDnCal, MealName.Dinner);

            UpdateTotals();
        }

        public void PopulateMealData(DateTime date, int userId, MealRepository mealRepository, DataGridView dataGridView, Label lblProt, Label lblKarb, Label lblFat, Label lblCal, MealName mealName)
        {
            var result = mealRepository.GetFoodsForMeal(date, mealName, userId);

            lblProt.Text = result.Sum(item => item.Protein).ToString();
            lblKarb.Text = result.Sum(item => item.Carbohydrate).ToString();
            lblFat.Text = result.Sum(item => item.Fat).ToString();
            lblCal.Text = result.Sum(item => item.Calories).ToString();



            dataGridView.DataSource = result;
            dataGridView.Columns["FoodCategoryId"].Visible = false;
            dataGridView.Columns["FoodCategory"].Visible = false;
            dataGridView.Columns["Id"].Visible = false;
            dataGridView.Columns["Status"].Visible = false;
            dataGridView.Columns["CreateDate"].Visible = false;
            dataGridView.Columns["Picture"].Visible = false;


            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;




            // Sütun başlıklarını Türkçe olarak ayarlayın
            dataGridView.Columns["FoodName"].HeaderText = "Besin Adı";
            dataGridView.Columns["Protein"].HeaderText = "Protein";
            dataGridView.Columns["Carbohydrate"].HeaderText = "Karbonhidrat";
            dataGridView.Columns["Calories"].HeaderText = "Kalori";
            dataGridView.Columns["Fat"].HeaderText = "Yağ";
            dataGridView.Columns["Description"].HeaderText = "Açıklama";
            dataGridView.Columns["PortionQuantity"].HeaderText = "Porsiyon";

        }
        public void UpdateTotals()
        {

            lblTotalCal.Text = (Convert.ToDouble(lblBrCal.Text) +
                                Convert.ToDouble(lblLnCal.Text) +
                                Convert.ToDouble(lblDnCal.Text)).ToString();

            lblTotalProt.Text = (Convert.ToDouble(lblBrProt.Text) +
                                Convert.ToDouble(lblLnProt.Text) +
                                Convert.ToDouble(lblDnProt.Text)).ToString();

            lblTotalCar.Text = (Convert.ToDouble(lblBrKarb.Text) +
                                Convert.ToDouble(lblLnKarb.Text) +
                                Convert.ToDouble(lblDnCar.Text)).ToString();

            lblTotalFat.Text = (Convert.ToDouble(lblBrFat.Text) +
                                Convert.ToDouble(lblLnFat.Text) +
                                Convert.ToDouble(lblDnFat.Text)).ToString();
        }



        private void pbReturn_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Uygulamadan Ayrılıyorsunuz, Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                new Login().Show();
                this.Hide();
            }
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Form kapatıldığında uygulamayı da kapatın
            Application.Exit();
        }

        private void kAÇKALORİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HowManyCalories howManyCalories = new HowManyCalories();
            howManyCalories.ShowDialog();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }
        private void pbBreakfast_Click(object sender, EventArgs e)
        {
            Breakfast breakfast = new Breakfast();
            breakfast.GetUserId(_userId, dtpDateTime.Value);
            breakfast.ShowDialog();
            GetFiilFood();
        }

        private void pbLunch_Click(object sender, EventArgs e)
        {
            Lunch lunch = new Lunch();
            lunch.GetUserId(_userId, dtpDateTime.Value);
            lunch.ShowDialog();
            GetFiilFood();

        }

        private void pbDinner_Click(object sender, EventArgs e)
        {
            Dinner dinner = new Dinner();
            dinner.GetUserId(_userId, dtpDateTime.Value);
            dinner.ShowDialog();
            GetFiilFood();

        }
        private void dtpDateTime_ValueChanged(object sender, EventArgs e)
        {
            GetFiilFood();
        }
        public void UserInformation(int userID)
        {
            _userId = userID;

            var result = userRepository.Find(x => x.Id == userID);
            var userDetail = userDetailRepository.Find(x => x.UserId == userID);

            lblUser.Text = $"Merhaba {result.UserName}. Hoş Geldiniz";
            lblHeight.Text = userDetail.Height.ToString();
            lblWeight.Text = userDetail.Weight.ToString();
        }

        private void btnBrFoodDelete_Click(object sender, EventArgs e)
        {
            // DataGridView'de seçilen satırdaki gıdayı almak için varsayılan olarak kullanılır.
            var selectedFood = dataGridView1.SelectedRows[0].DataBoundItem as Food;

            // Eğer seçilen bir gıda varsa devam et
            if (selectedFood != null)
            {
                // Silinecek gıdayı belirlemek için kullanılacak öğün adı
                var mealName = MealName.BrakFast;

                // Gıdayı yemekten çıkarmak için ilgili metodunu çağır
                mealRepository.RemoveFoodFromMeal(selectedFood.Id, dtpDateTime.Value, mealName, _userId);

                // DataGridView'ı güncelleyerek veya gerekli görsel değişiklikleri yaparak kullanıcı arayüzünü güncelle
                GetFiilFood();
            }
            else
            {
                MessageBox.Show("Seçilen gıda bir öğüne ait değil.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBrDelete_Click(object sender, EventArgs e)
        {
            // Silinecek ogün
            var mealName = MealName.BrakFast;

            // Oğunu silmek için kullanılacak method
            mealRepository.RemoveMealAndAllFood(dtpDateTime.Value, mealName, _userId);

            // DataGridView'ı güncelleyerek veya gerekli görsel değişiklikleri yaparak kullanıcı arayüzünü güncelle
            GetFiilFood();
        }

        private void btnLnDelete_Click(object sender, EventArgs e)
        {
            // Silinecek ogün
            var mealName = MealName.Lunch;

            // Oğunu silmek için kullanılacak method
            mealRepository.RemoveMealAndAllFood(dtpDateTime.Value, mealName, _userId);

            // DataGridView'ı güncelleyerek veya gerekli görsel değişiklikleri yaparak kullanıcı arayüzünü güncelle
            GetFiilFood();
        }

        private void btnLnDeleteFood_Click(object sender, EventArgs e)
        {
            // DataGridView'de seçilen satırdaki gıdayı almak için varsayılan olarak kullanılır.
            var selectedFood = dataGridView2.SelectedRows[0].DataBoundItem as Food;

            // Eğer seçilen bir gıda varsa devam et
            if (selectedFood != null)
            {
                // Silinecek gıdayı belirlemek için kullanılacak öğün adı
                var mealName = MealName.Lunch;

                // Gıdayı yemekten çıkarmak için ilgili metodunu çağır
                mealRepository.RemoveFoodFromMeal(selectedFood.Id, dtpDateTime.Value, mealName, _userId);

                // DataGridView'ı güncelleyerek veya gerekli görsel değişiklikleri yaparak kullanıcı arayüzünü güncelle
                GetFiilFood();
            }
        }

        private void btnDnDelete_Click(object sender, EventArgs e)
        {
            // Silinecek ogün
            var mealName = MealName.Dinner;

            // Oğunu silmek için kullanılacak method
            mealRepository.RemoveMealAndAllFood(dtpDateTime.Value, mealName, _userId);

            // DataGridView'ı güncelleyerek veya gerekli görsel değişiklikleri yaparak kullanıcı arayüzünü güncelle
            GetFiilFood();
        }

        private void btnDnDeleteFood_Click(object sender, EventArgs e)
        {
            // DataGridView'de seçilen satırdaki gıdayı almak için varsayılan olarak kullanılır.
            var selectedFood = dataGridView3.SelectedRows[0].DataBoundItem as Food;

            // Eğer seçilen bir gıda varsa devam et
            if (selectedFood != null)
            {
                // Silinecek gıdayı belirlemek için kullanılacak öğün adı
                var mealName = MealName.Dinner;

                // Gıdayı yemekten çıkarmak için ilgili metodunu çağır
                mealRepository.RemoveFoodFromMeal(selectedFood.Id, dtpDateTime.Value, mealName, _userId);

                // DataGridView'ı güncelleyerek veya gerekli görsel değişiklikleri yaparak kullanıcı arayüzünü güncelle
                GetFiilFood();
            }
        }

        private void lblTotalCal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                circularProgressBar1.Value = Convert.ToInt32(lblTotalCal.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Günlük Kalori ihtiyacını Geçtiniz!!!");
                circularProgressBar1.Value = 2999;
            }

        }

        private void üYELİKİŞLEMLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberShipForm memberShipForm = new MemberShipForm();
            memberShipForm.UserInformation(_userId);
            memberShipForm.Show();
        }

        private void yEMEKTARİFİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewFood createNewFood = new CreateNewFood();
            createNewFood.ShowDialog();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Çift tıklanan satırın indeksi
            int rowIndex = e.RowIndex;

            // İlgili Food nesnesini al
            Food selectedFood = dataGridView1.Rows[rowIndex].DataBoundItem as Food;

            // Food nesnesini başka forma gönder
            if (selectedFood != null)
            {
                CreateNewFood createNewFood = new CreateNewFood();
                createNewFood.SetFood(selectedFood);
                createNewFood.ShowDialog();
                GetFiilFood();
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Çift tıklanan satırın indeksi
            int rowIndex = e.RowIndex;

            // İlgili Food nesnesini al
            Food selectedFood = dataGridView2.Rows[rowIndex].DataBoundItem as Food;

            // Food nesnesini başka forma gönder
            if (selectedFood != null)
            {
                CreateNewFood createNewFood = new CreateNewFood();
                createNewFood.SetFood(selectedFood);
                createNewFood.ShowDialog();
                GetFiilFood();
            }
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Çift tıklanan satırın indeksi
            int rowIndex = e.RowIndex;

            // İlgili Food nesnesini al
            Food selectedFood = dataGridView3.Rows[rowIndex].DataBoundItem as Food;

            // Food nesnesini başka forma gönder
            if (selectedFood != null)
            {
                CreateNewFood createNewFood = new CreateNewFood();
                createNewFood.SetFood(selectedFood);
                createNewFood.ShowDialog();
                GetFiilFood();
            }
        }

        private void günSonuRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportEndOfDay reportEndOfDay = new ReportEndOfDay();
            reportEndOfDay.UserInformation(_userId, dtpDateTime.Value);
            reportEndOfDay.Show();
        }
        private void öğünBazlıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportMealTotal reportMealTotal = new ReportMealTotal();
            reportMealTotal.UserInformation(_userId, dtpDateTime.Value);
            reportMealTotal.Show();
        }

        private void kattegoriBazlıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportCategoryTotal reportCategoryTotal = new ReportCategoryTotal();
            reportCategoryTotal.UserInformation(_userId, dtpDateTime.Value);
            reportCategoryTotal.Show();
        }

        private void yemekÇeşidiRaporlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportMostEatFood reportMostEatFood = new ReportMostEatFood();
            reportMostEatFood.UserInformation(_userId, dtpDateTime.Value);
            reportMostEatFood.Show();
        }
    }
}
