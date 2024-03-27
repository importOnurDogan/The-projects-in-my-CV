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
    public partial class CreateNewFood : Form
    {
        FoodRepository foodRepository = new FoodRepository();
        FoodCategoryRepository categoryRepository = new FoodCategoryRepository();
        PictureHelper pictureHelper = new PictureHelper();
        string picturePath;
        int selectedCategoryId;
        private Food selectedFood;
        int portionQuantity;
        int secim;
        public CreateNewFood()
        {
            InitializeComponent();
        }
        private void CreateNewFood_Load(object sender, EventArgs e)
        {
            // ComboBox'a kategori nesnelerini ekleyin
            cmbCategory.DataSource = categoryRepository.GetAll();
            cmbCategory.DisplayMember = "CategoryName"; // Kategori adlarını göstermek için
            cmbCategory.ValueMember = "Id"; // Kategori ID'sini almak için


        }
        private void btnCreatFood_Click(object sender, EventArgs e)
        {
            try
            {
                if (secim == 2)
                {
                    // Var olan Food kaydını kontrol et
                    Food existingFood = foodRepository.GetAll().FirstOrDefault(x => x.Id == selectedFood.Id);

                    // Eğer varsa güncelle
                    existingFood.FoodName = txtFoodName.Text;
                    existingFood.Calories = (Convert.ToInt32(txtCalori.Text) / portionQuantity) * Convert.ToInt32(txtPortion.Value);
                    existingFood.Carbohydrate = (Convert.ToDouble(txtCar.Text) / portionQuantity) * Convert.ToInt32(txtPortion.Value);
                    existingFood.Protein = (Convert.ToDouble(txtProt.Text) / portionQuantity) * Convert.ToInt32(txtPortion.Value);
                    existingFood.Fat = (Convert.ToDouble(txtFat.Text) / portionQuantity) * Convert.ToInt32(txtPortion.Value);
                    existingFood.Status = Status.Active;
                    existingFood.Description = txtDescription.Text;
                    existingFood.PortionQuantity = Convert.ToInt32(txtPortion.Value);
                    // Eğer resim tekrar seçilmediyse mevcut binary kodunu kullan
                    if (!string.IsNullOrEmpty(picturePath))
                    {
                        existingFood.Picture = pictureHelper.ConvertImageToByteArray(picturePath);
                    }
                    existingFood.PortionQuantity = Convert.ToInt32(txtPortion.Text);
                    existingFood.FoodCategoryId = selectedCategoryId;

                    foodRepository.Update(existingFood);

                    // Güncellendiğine dair bilgi mesajı göster
                    MessageBox.Show("Yemek başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                }
                else
                {
                    portionQuantity = 1;
                    // Eğer yoksa yeni ekle
                    Food newFood = new Food
                    {
                        FoodName = txtFoodName.Text,
                        Calories = (Convert.ToInt32(txtCalori.Text) / portionQuantity) * Convert.ToInt32(txtPortion.Value),
                        Carbohydrate = (Convert.ToDouble(txtCar.Text) / portionQuantity) * Convert.ToInt32(txtPortion.Value),
                        Protein = (Convert.ToDouble(txtProt.Text) / portionQuantity) * Convert.ToInt32(txtPortion.Value),
                        Fat = (Convert.ToDouble(txtFat.Text) / portionQuantity) * Convert.ToInt32(txtPortion.Value),
                        Status = Status.Active,
                        Description = txtDescription.Text,
                        Picture = pictureHelper.ConvertImageToByteArray(picturePath),
                        PortionQuantity = Convert.ToInt32(txtPortion.Value),
                        FoodCategoryId = selectedCategoryId
                    };

                    foodRepository.Add(newFood);

                    // Yeni eklediğine dair bilgi mesajı göster
                    MessageBox.Show("Yemek başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya hata mesajı göster
                MessageBox.Show("Yemek eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            pbPicture.Image = pictureHelper.ChooseImage(out picturePath);
            pbPicture.Tag = picturePath;
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem != null)
            {
                // cmbCategory.SelectedValue'nin türünü kontrol et
                if (cmbCategory.SelectedValue is int)
                {
                    selectedCategoryId = (int)cmbCategory.SelectedValue;
                    // Artık selectedCategoryId değişkeni seçilen kategorinin ID'sini içerir
                }
            }

        }
        public void SetFood(Food food)
        {
            secim = 2;
            portionQuantity = food.PortionQuantity;
            selectedFood = food;
            txtFoodName.Text = food.FoodName;
            txtCalori.Text = food.Calories.ToString();
            txtCar.Text = food.Carbohydrate.ToString();
            txtProt.Text = food.Protein.ToString();
            txtFat.Text = food.Fat.ToString();
            txtDescription.Text = food.Description;
            txtPortion.Value = food.PortionQuantity;

            var allCategories = categoryRepository.GetAll(); // Category listesini al
            cmbCategory.DataSource = allCategories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "Id";

            // food.FoodCategoryId ile eşleşen kategori ID'sini al
            int desiredCategoryId = food.FoodCategoryId;

            // Eşleşen kategori öğesini bul
            FoodCategory selectedCategory = allCategories.FirstOrDefault(c => c.Id == desiredCategoryId);

            // Eğer eşleşen bir kategori bulunduysa, onu seçili olarak ayarla
            if (selectedCategory != null)
            {

                // selectedCategory'yi cmbCategory'nin veri kaynağı içinde bul ve seçili olarak ayarla
                cmbCategory.SelectedItem = selectedCategory;
            }
            pbPicture.Image = pictureHelper.ShowImageFromDatabase(food.Picture);
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
