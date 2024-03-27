using DietPlus.Core.Enum;
using DietPlus.Entities;
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
    public partial class HowManyCalories : Form
    {
        FoodRepository foodRepository = new FoodRepository();
        PictureHelper pictureHelper = new PictureHelper();
        public HowManyCalories()
        {
            InitializeComponent();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        }

        private void HowManyCalories_Load(object sender, EventArgs e)
        {
            GetAllFood();
        }

        private void GetAllFood()
        {
            DataGridViewHelper.SetupFoodDataGridView(dataGridView1, foodRepository);
        }
        private void ResetDataGridView()
        {
            DataGridViewHelper.ResetDataGridView(dataGridView1);
        }
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            ResetDataGridView();
            GetAllFood();
            dataGridView1.DataSource = foodRepository.GetAllByTextChange(txtFind.Text);
        }

        private int count = 0;

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (count != 1)
            {
                // DataGridView'de seçilen satırdaki gıdayı almak için varsayılan olarak kullanılır.
                var food = dataGridView1.SelectedRows[0].DataBoundItem as Food;

                // Eğer seçilen bir gıda varsa devam et
                if (food != null)
                {
                    lblFoodName.Text = food.FoodName;
                    lblKalori.Text = $"Kalori: {food.Calories}";
                    pbPicture.Image = pictureHelper.ShowImageFromDatabase(food.Picture);
                    pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show("Seçilen gıda bir öğüne ait değil.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Olayın tekrar tetiklenmesini önlemek için count değerini sıfırla
                count = 0;
            }

            count++;
        }

    }
}