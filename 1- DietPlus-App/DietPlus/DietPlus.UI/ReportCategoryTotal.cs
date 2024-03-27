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
    public partial class ReportCategoryTotal : Form
    {
        public ReportCategoryTotal()
        {
            InitializeComponent();
        }
        MealRepository mealRepository = new MealRepository();
        int _userId;
        DateTime _date;
        private void pbReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            DataGridViewHelper.ResetDataGridView(dataGridView1);
            var result = mealRepository.GetTotalCaloriesPerCategoryMonth(_date);
            dataGridView1.DataSource = result;

            dataGridView1.Columns["CategoryName"].HeaderText = "Kategori";
            dataGridView1.Columns["TotalCaloriesPerCategory"].HeaderText = "Toplam Kalori";

            // DataGridView'daki tüm sütunların genişliklerini otomatik olarak ayarla
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Gerekirse son sütunu içeriğe göre genişlet
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            decimal totalCalories = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["TotalCaloriesPerCategory"].Value != null)
                {
                    decimal calories;
                    if (decimal.TryParse(row.Cells["TotalCaloriesPerCategory"].Value.ToString(), out calories))
                    {
                        totalCalories += calories;
                    }
                }
            }

            // Toplam kaloriyi kullanabilirsiniz

            lblSumCal.Text = totalCalories.ToString();
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            DataGridViewHelper.ResetDataGridView(dataGridView1);
            var result = mealRepository.GetTotalCaloriesPerCategoryWeek(_date);
            dataGridView1.DataSource = result;

            dataGridView1.Columns["CategoryName"].HeaderText = "Kategori";
            dataGridView1.Columns["TotalCaloriesPerCategory"].HeaderText = "Toplam Kalori";

            // DataGridView'daki tüm sütunların genişliklerini otomatik olarak ayarla
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Gerekirse son sütunu içeriğe göre genişlet
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            decimal totalCalories = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["TotalCaloriesPerCategory"].Value != null)
                {
                    decimal calories;
                    if (decimal.TryParse(row.Cells["TotalCaloriesPerCategory"].Value.ToString(), out calories))
                    {
                        totalCalories += calories;
                    }
                }
            }

            // Toplam kaloriyi kullanabilirsiniz

            lblSumCal.Text = totalCalories.ToString();
        }

        private void ReportMealTotal_Load(object sender, EventArgs e)
        {

        }
        public void UserInformation(int userID, DateTime date)
        {
            _userId = userID;
            _date = date;
            var result = mealRepository.GetTotalCaloriesPerCategory();
            dataGridView1.DataSource = result;

            dataGridView1.Columns["CategoryName"].HeaderText = "Kategori";
            dataGridView1.Columns["TotalCaloriesPerCategory"].HeaderText = "Toplam Kalori";
   
            // DataGridView'daki tüm sütunların genişliklerini otomatik olarak ayarla
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Gerekirse son sütunu içeriğe göre genişlet
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            decimal totalCalories = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["TotalCaloriesPerCategory"].Value != null)
                {
                    decimal calories;
                    if (decimal.TryParse(row.Cells["TotalCaloriesPerCategory"].Value.ToString(), out calories))
                    {
                        totalCalories += calories;
                    }
                }
            }

            // Toplam kaloriyi kullanabilirsiniz

            lblSumCal.Text = totalCalories.ToString();

        }
    }
}