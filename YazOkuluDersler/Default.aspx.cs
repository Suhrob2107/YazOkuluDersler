using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer; // EntityLayer namespace'ini kullanabilmek icin referans eklenmeli
using BusinessLogicLayer; // BusinessLogicLayer namespace'ini kullanabilmek icin referans eklenmeli
using DataAccessLayer; // DataAccessLayer namespace'ini kullanabilmek icin referans eklenmeli

namespace YazOkuluDersler
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //EntityOgrenci ent = new EntityOgrenci();
            //ent.Ad = "Derya";
            //ent.Soyad = "Yılmaz";
            //ent.Numara = "1166";
            //ent.Sifre = "123";
            //ent.Fotograf = "derya.jpg";
            //BLLOgrenci.OgrenciEkleBLL(ent); // BLLOgrenci sınıfındaki OgrenciEkleBLL metodunu çağırır

            EntityOgrenci ent = new EntityOgrenci();
            ent.Ad = TxtAd.Text; // TextBox'tan alınan değerleri EntityOgrenci nesnesine atar
            ent.Soyad = TxtSoyad.Text;
            ent.Numara = TxtNumara.Text;
            ent.Sifre = TxtSifre.Text;
            ent.Fotograf = TxtFoto.Text; // Fotoğraf için bir URL veya dosya adı alındığını varsayıyoruz
            BLLOgrenci.OgrenciEkleBLL(ent); // BLLOgrenci sınıfındaki OgrenciEkleBLL metodunu çağırır
        }
    }
}
// 8 . Default.aspx.cs dosyasını yaz