using DietPlus.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietPlus.UI.Helper
{
    // Yeni bir sınıf oluştur
    public class DataGridViewHelper
    {
        public static void ResetDataGridView(DataGridView dataGridView)
        {
            // DataGridView'deki veri kaynağını boşalt
            dataGridView.DataSource = null;

            // DataGridView'deki tüm satırları temizle
            dataGridView.Rows.Clear();

            // DataGridView'deki tüm sütunları temizle
            dataGridView.Columns.Clear();

            // Seçili hücreleri temizle
            dataGridView.ClearSelection();

            // Diğer gerekli özellikleri sıfırla veya ayarla
            // Örneğin, tekrar sütunları oluşturabilir veya yeni bir veri kaynağı atayabilirsiniz.
        }

        public static void SetupFoodDataGridView(DataGridView dataGridView, FoodRepository foodRepository)
        {
            // DataGridView'deki sütunları otomatik oluşturmayı devre dışı bırak
            dataGridView.AutoGenerateColumns = false;

            // Food sınıfındaki istediğiniz özelliklere karşılık gelen DataGridViewTextBoxColumn'ları ekleyin
            DataGridViewColumn foodIdColumn = new DataGridViewTextBoxColumn();
            foodIdColumn.DataPropertyName = "id"; // Food sınıfındaki FoodName özelliği ile eşleşir
            foodIdColumn.HeaderText = "ID";
            dataGridView.Columns.Add(foodIdColumn);

            DataGridViewColumn foodNameColumn = new DataGridViewTextBoxColumn();
            foodNameColumn.DataPropertyName = "FoodName"; // Food sınıfındaki FoodName özelliği ile eşleşir
            foodNameColumn.HeaderText = "Besin Adı";
            dataGridView.Columns.Add(foodNameColumn);

            DataGridViewColumn caloriesColumn = new DataGridViewTextBoxColumn();
            caloriesColumn.DataPropertyName = "Calories";
            caloriesColumn.HeaderText = "Kalori";
            dataGridView.Columns.Add(caloriesColumn);

            DataGridViewColumn fatColumn = new DataGridViewTextBoxColumn();
            fatColumn.DataPropertyName = "Fat"; // Food sınıfındaki FoodName özelliği ile eşleşir
            fatColumn.HeaderText = "Yağ";
            dataGridView.Columns.Add(fatColumn);

            DataGridViewColumn carbohydrateColumn = new DataGridViewTextBoxColumn();
            carbohydrateColumn.DataPropertyName = "Carbohydrate";
            carbohydrateColumn.HeaderText = "Karbonhidrat";
            dataGridView.Columns.Add(carbohydrateColumn);

            DataGridViewColumn proteinColumn = new DataGridViewTextBoxColumn();
            proteinColumn.DataPropertyName = "Protein";
            proteinColumn.HeaderText = "Protein";
            dataGridView.Columns.Add(proteinColumn);

            // DataGridView'e verileri bağla
            dataGridView.DataSource = foodRepository.GetAll();
        }
    }
}
