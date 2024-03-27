using BAPersonelTakipUygulamam.BLL.Concrete;

namespace BAPersonelTakipUygulamam.UI
{
    public partial class Form1 : Form
    {
        //      Personel Takip Uygulaması
        //  Personellerin CRUD işlemlerini yapabileceğimiz bir proje isityoruz. (+2)
        //  Bu projede bugüne kadar öğrendiğiniz herşeyi kullanabilirsiniz.
        //  Personel Bilgileri:
        //  -AD
        //  -Soyad
        //  -Yaş(veritabanına eklenmeyecek) (+1)
        //  -DoğumTarihi
        //  -İşe giriş tarihi
        //  -Biyografi
        //  -Departmanı(Birden fazla seçenek içinden seçilecek, Enum olmayacak. Veritabanından gelecek)
        //* farklı formlar ve menü kullanarak bu işlemi gerçekleştirebilirsiniz. (+2)



        public Form1()
        {
            InitializeComponent();
        }

        PersonelRepository pr = new PersonelRepository();
        private void btnPersonelleriGoster_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pr.GetAll();
        }
    }
}