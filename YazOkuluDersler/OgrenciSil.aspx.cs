using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace YazOkuluDersler
{
    public partial class OgrenciSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OGRID"]); // QueryString ile gelen OgrenciID değerini alıyoruz
            Response.Write(x); // Debug amaçlı olarak OgrenciID değerini yazdırıyoruz
            EntityOgrenci ent = new EntityOgrenci(); // EntityOgrenci sınıfından bir nesne oluşturuyoruz
            ent.Id = x; // OgrenciID değerini EntityOgrenci nesnesinin Id özelliğine atıyoruz
            BLLOgrenci.OgrenciSilBLL(ent.Id); // BLLOgrenci sınıfının OgrenciSilBLL metodunu çağırarak öğrenci silme işlemini gerçekleştiriyoruz
            Response.Redirect("OgrenciListesi.aspx"); // Silme işlemi tamamlandıktan sonra OgrenciListesi sayfasına yönlendiriyoruz
        }
    }
}