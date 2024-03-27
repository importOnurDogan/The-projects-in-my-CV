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

namespace DietPlus.UI.Properties
{
    public partial class ReportMostEatFood : Form
    {
        MealRepository mealRepository = new MealRepository();
        int _userId;
        DateTime _date;
        public ReportMostEatFood()
        {
            InitializeComponent();
        }
        private void pbReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            DataGridViewHelper.ResetDataGridView(dataGridView1);
            var result = mealRepository.GetMosteatFoodMonth(_date);
            dataGridView1.DataSource = result;

            dataGridView1.Columns["MealName"].HeaderText = "Öğün";
            dataGridView1.Columns["FoodName"].HeaderText = "Besin Adı";
            dataGridView1.Columns["TotalPortion"].HeaderText = "Toplama Porsiyon";
            dataGridView1.Columns["MealNameStringRepresentation"].Visible = false;

            // DataGridView'daki tüm sütunların genişliklerini otomatik olarak ayarla
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Gerekirse son sütunu içeriğe göre genişlet
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            DataGridViewHelper.ResetDataGridView(dataGridView1);
            var result = mealRepository.GetMosteatFoodWeek(_date);
            dataGridView1.DataSource = result;

            dataGridView1.Columns["MealName"].HeaderText = "Öğün";
            dataGridView1.Columns["FoodName"].HeaderText = "Besin Adı";
            dataGridView1.Columns["TotalPortion"].HeaderText = "Toplama Porsiyon";
            dataGridView1.Columns["MealNameStringRepresentation"].Visible = false;

            // DataGridView'daki tüm sütunların genişliklerini otomatik olarak ayarla
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Gerekirse son sütunu içeriğe göre genişlet
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ReportMealTotal_Load(object sender, EventArgs e)
        {

        }
        public void UserInformation(int userID, DateTime date)
        {
            _userId = userID;
            _date = date;
            var result = mealRepository.GetMosteatFood();
            dataGridView1.DataSource = result;

            dataGridView1.Columns["MealName"].HeaderText = "Öğün";
            dataGridView1.Columns["FoodName"].HeaderText = "Besin Adı";
            dataGridView1.Columns["TotalPortion"].HeaderText = "Toplama Porsiyon";
            dataGridView1.Columns["MealNameStringRepresentation"].Visible = false;

            // DataGridView'daki tüm sütunların genişliklerini otomatik olarak ayarla
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Gerekirse son sütunu içeriğe göre genişlet
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}