using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietPlus.UI.Helper
{
    public class PictureHelper
    {
        public Image ChooseImage(out string resimyolu)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim | *.jpeg;*.png;*.jpg";
            DialogResult cvp = openFileDialog.ShowDialog();
            if (cvp == DialogResult.OK)
            {
                resimyolu = openFileDialog.FileName;
                return Image.FromFile(openFileDialog.FileName);
            }

            resimyolu = string.Empty;
            return null;
        }
        public byte[] ConvertImageToByteArray(string imagePath)
        {
            byte[] imageBytes;
            using (FileStream fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader binaryReader = new BinaryReader(fileStream))
                {
                    imageBytes = binaryReader.ReadBytes((int)fileStream.Length);
                }
            }
            return imageBytes;
        }
        public Image ShowImageFromDatabase(byte[] imageData)
        {
            try
            {
                // Byte dizisini MemoryStream'e dönüştürme
                using (MemoryStream memoryStream = new MemoryStream(imageData))
                {
                    // MemoryStream'den Image nesnesini oluşturma
                    Image image = Image.FromStream(memoryStream);

                    // Image'ı geri döndürme
                    return image;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Resim gösterme hatası: " + ex.Message);
                return null; // Hata durumunda null döndürme
            }
        }


    }
}
