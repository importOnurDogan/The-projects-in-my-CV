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
    public partial class WhoAreWe : Form
    {
        public WhoAreWe()
        {
            InitializeComponent();
        }

        private void WhoAreWe_Load(object sender, EventArgs e)
        {


            lblBizKimiz.Text = "Merhaba! sağlıklı bir yaşamın kapılarını aralayan bir diyet yolculuğuna hoş geldiniz.\nBiz, Diyet+ geliştirici ekibi olarak, sizin sağlığınıza değer veren ve kişiselleştirilmiş \nraporlama ve besin bilgisi deneyimleri sunan bir ekibiz.";

            lblMisyon.Text = "Diyet+ geliştirici ekibi olarak sağlıklı ve düzenli beslenmenin ne kadar önemli olduğunu biliyoruz. \nBu doğrultuda kullanıcılarımıza sağlıklı beslenme alışkanlıkları kazandırmak ve yaşam kalitelerini arttırma \nhedeflerine ulaşmalarına yardımcı olmak en önemli amacimizdir.";

            lblEkip.Text = "Diyet+ geliştirici ekibi; size en iyi hizmeti sunabilmek için her türlü araştırmayı yapmış, \nnitelikli profesyonellerden oluşmaktadır. Her bir ekip üyesi, kullanıcılarımıza en iyi deneyimi \nsunmak için bilgi birikimi, tutku ve deneyimle doludur.\r\nEkip Üyeleri :\r\n- Proje Yöneticisi : Murat Yeydem\r\n- Nitelikli yazılımcı : Burak Çırak\r\n- Nitelikli yazılımcı : Onur Doğan";

            lblGeriBiildirim.Text = "Sizlerle iletişim halinde olmak, geri bildirimlerinizi almak ve uygulamamızı sürekli olarak geliştirmek \nbizim için bir önceliktir. İhtiyaçlarınıza daha iyi yanıt verebilmek için bize her zaman ulaşabilir ve \nönerilerinizi paylaşabilirsiniz.\r\n\r\nDiyet+ gelistirici ekibi, sağlıklı bir yaşamın kapılarını aralayan bir yolculuğa başlamanız için burada. \nSizleri destekleyerek, daha sağlıklı, mutlu ve enerjik bir yaşama adım atmanıza yardımcı olmayı \nsabırsızlıkla bekliyoruz!\n\n\n";
        }

        private void WhoAreWe_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();

        }
    }
}
