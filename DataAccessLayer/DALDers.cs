using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALDers
    {
        public static List<EntityDers> DersListesi() // 19. E Geldik
        {
            List<EntityDers> degerler = new List<EntityDers>(); // Ders listesini tutmak icin bir liste olusturduk
            SqlCommand komut2 = new SqlCommand("select * from TblDersler", Baglanti.bgl); // SqlCommand ile veritabanina baglanip sorgu yapacagiz
            if (komut2.Connection.State != ConnectionState.Open) // Baglanti kontrolu yapar, baglanti acik degilse acar
            {
                komut2.Connection.Open(); // Baglanti acilir
            }
            SqlDataReader dr = komut2.ExecuteReader(); // ExecuteReader -> select islemleri icin kullanilir, ve verileri dondurur
            while (dr.Read()) // DataReader ile verileri okur
            {
                EntityDers ent = new EntityDers();
                ent.Id = Convert.ToInt32(dr["dersid"]);
                ent.Dersad = dr["dersad"].ToString();
                ent.Min =Convert.ToInt32(dr["dersminkont"].ToString());
                ent.Max =Convert.ToInt32(dr["dersmakskont"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            Baglanti.bgl.Close();
            return degerler;
        }
        public static int TalepEkle(EntityBasvuruForm parametre)
        {
            SqlCommand komut = new SqlCommand("insert into tblbasvuruform (ogrenciid,dersid) values (@p1,@p2)", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", parametre.Basogrid);
            komut.Parameters.AddWithValue("@p2", parametre.Basdersid);
            if (komut.Connection.State != ConnectionState.Open) // Baglanti kontrolu yapar, baglanti acik degilse acar
            {
                komut.Connection.Open(); // Baglanti acilir
            }
            return komut.ExecuteNonQuery();
        }
    }
}
