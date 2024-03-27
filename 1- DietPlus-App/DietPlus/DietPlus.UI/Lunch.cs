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
    public partial class Lunch : Form
    {
        FoodRepository foodRepository = new FoodRepository();
        MealRepository mealRepository = new MealRepository();
        UserRepository userRepository = new UserRepository();
        int _selectedFood = 0;
        int _userId = 2;
        DateTime _date;
        public Lunch()
        {
            InitializeComponent();
        }

        private void txtFindFood_TextChanged(object sender, EventArgs e)
        {
            ResetDataGridView();
            GetAllFood();
            dataGridView1.DataSource = foodRepository.GetAllByTextChange(txtFindFood.Text);
        }
        private void GetAllFood()
        {
            DataGridViewHelper.SetupFoodDataGridView(dataGridView1, foodRepository);
        }
        private void ResetDataGridView()
        {
            DataGridViewHelper.ResetDataGridView(dataGridView1);
        }
        private void btnChoose_Click(object sender, EventArgs e)
        {
            var food = foodRepository.Find(x => x.Id == _selectedFood);
            var user = userRepository.Find(x => x.Id == _userId);
            mealRepository.AddFoodToMeal(food, MealName.Lunch, user,_date);
            this.Hide();
        }

        public void GetUserId(int userId,DateTime date)
        {
            _userId = userId;
            _date = date;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçili satır varsa işlemleri gerçekleştir
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Seçilen satırın Id özelliğini al
                if (int.TryParse(selectedRow.Cells[0].Value.ToString(), out int foodId))
                {
                    _selectedFood = foodId;

                }
            }
        }

        private void Lunch_Load(object sender, EventArgs e)
        {
            GetAllFood();
        }
    }
}
