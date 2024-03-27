using DietPlus.Core.Enum;
using DietPlus.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DietPlus.UI
{
    public partial class ReportEndOfDay : Form
    {
        public ReportEndOfDay()
        {
            InitializeComponent();
        }
        MealRepository mealRepository = new MealRepository();
        private void ReportEndOfDay_Load(object sender, EventArgs e)
        {

        }
        public void UserInformation(int userID, DateTime date)
        {

            var result = mealRepository.GetTotalCaloriesForUserAndDate(date, userID);
            dataGridView1.DataSource = result;

            dataGridView1.Columns["MealName"].HeaderText = "Öğün";
            dataGridView1.Columns["TotalCaloriesPerMeal"].HeaderText = "Toplam Kalori";
            dataGridView1.Columns["MealNameStringRepresentation"].Visible = false;

            // DataGridView'daki tüm sütunların genişliklerini otomatik olarak ayarla
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Gerekirse son sütunu içeriğe göre genişlet
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            decimal totalCalories = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["TotalCaloriesPerMeal"].Value != null)
                {
                    decimal calories;
                    if (decimal.TryParse(row.Cells["TotalCaloriesPerMeal"].Value.ToString(), out calories))
                    {
                        totalCalories += calories;
                    }
                }
            }

            // Toplam kaloriyi kullanabilirsiniz

            lblSumCal.Text = totalCalories.ToString();

        }

        private void pbReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
