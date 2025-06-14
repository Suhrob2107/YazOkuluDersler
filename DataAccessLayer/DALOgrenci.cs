using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer; // EntityLayer namespace'i eklenmeli DataAccesLayer icinde referance -> Add reference -> EntityLayer

namespace DataAccessLayer
{
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into TblOgrenci (Ograd,ogrsoyad,OgrNumara,OGRFOTO,OgrSifre)" +
                " values (@p1,@p2,@p3,@p4,@p5)", Baglanti.bgl);
            if(komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", parametre.Ad); // EntityOgrenci icinde bulunan propartileri getirecek
            komut1.Parameters.AddWithValue("@p2", parametre.Soyad);
            komut1.Parameters.AddWithValue("@p3", parametre.Numara);
            komut1.Parameters.AddWithValue("@p4", parametre.Fotograf);
            komut1.Parameters.AddWithValue("@p5", parametre.Sifre);
            return komut1.ExecuteNonQuery(); // ExecuteNonQuery -> insert, update, delete islemleri icin kullanilir, ve verileri dondurur
        }

        public static List<EntityOgrenci> OgrenciLestesi() // 11. E Geldik
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>(); // Ogrenci listesini tutmak icin bir liste olusturduk
            SqlCommand komut2 = new SqlCommand("select * from TblOgrenci", Baglanti.bgl); // SqlCommand ile veritabanina baglanip sorgu yapacagiz
            if (komut2.Connection.State != ConnectionState.Open) // Baglanti kontrolu yapar, baglanti acik degilse acar
            {
                komut2.Connection.Open(); // Baglanti acilir
            }
            SqlDataReader dr = komut2.ExecuteReader(); // ExecuteReader -> select islemleri icin kullanilir, ve verileri dondurur
            while (dr.Read()) // DataReader ile verileri okur
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Id = Convert.ToInt32(dr["Ogrid"]); 
                ent.Ad = dr["Ograd"].ToString();
                ent.Soyad = dr["ogrsoyad"].ToString();
                ent.Numara = dr["OgrNumara"].ToString();
                ent.Fotograf = dr["OGRFOTO"].ToString();
                ent.Bakiye = Convert.ToDouble(dr["OgrBakiye"]).ToString();
                ent.Sifre = dr["OgrSifre"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            Baglanti.bgl.Close();
            return degerler;
        }

        // silme islemini buradan basldik. icin bir metod olusturduk
        public static bool OgrenciSil(int id) // 12. E Geldik 
        {
            SqlCommand komut3 = new SqlCommand("delete from TblOgrenci where Ogrid=@p1", Baglanti.bgl); // Ogrid parametresine gore silme islemi yapacagiz
            if (komut3.Connection.State != ConnectionState.Open) // Baglanti kontrolu yapar, baglanti acik degilse acar
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", id); // Silinecek ogrencinin id'sini parametre olarak alir
            return komut3.ExecuteNonQuery() > 0;    // ExecuteNonQuery -> insert, update, delete islemleri icin kullanilir, ve verileri dondurur
        }

        public static List<EntityOgrenci> OgrenciDetay(int id) // 
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>(); // Ogrenci listesini tutmak icin bir liste olusturduk
            SqlCommand komut4 = new SqlCommand("select * from TblOgrenci where OGRID=@p1", Baglanti.bgl); // SqlCommand ile veritabanina baglanip sorgu yapacagiz
            komut4.Parameters.AddWithValue("@p1", id);
            if (komut4.Connection.State != ConnectionState.Open) // Baglanti kontrolu yapar, baglanti acik degilse acar
            {
                komut4.Connection.Open(); // Baglanti acilir
            }
            SqlDataReader dr = komut4.ExecuteReader(); // ExecuteReader -> select islemleri icin kullanilir, ve verileri dondurur
            while (dr.Read()) // DataReader ile verileri okur
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Ad = dr["Ograd"].ToString();
                ent.Soyad = dr["ogrsoyad"].ToString();
                ent.Numara = dr["OgrNumara"].ToString();
                ent.Fotograf = dr["OGRFOTO"].ToString();
                ent.Bakiye = Convert.ToDouble(dr["OgrBakiye"]).ToString();
                ent.Sifre = dr["OgrSifre"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            Baglanti.bgl.Close();
            return degerler;
        }


        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            SqlCommand komut5 = new SqlCommand("update tblogrenci set ograd=@p1,ogrsoyad=@p2,ogrnumara=@p3,ogrfoto=@p4,ogrsifre=@p5 where ogrid = @p6", Baglanti.bgl);
            if(komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }
            komut5.Parameters.AddWithValue("@p1",deger.Ad);
            komut5.Parameters.AddWithValue("@p2",deger.Soyad);
            komut5.Parameters.AddWithValue("@p3",deger.Numara);
            komut5.Parameters.AddWithValue("@p4",deger.Fotograf);
            komut5.Parameters.AddWithValue("@p5",deger.Sifre);
            komut5.Parameters.AddWithValue("@p6",deger.Id);
            return komut5.ExecuteNonQuery() > 0;
        }
    }
}
// 7. DataAccessLayer icine DALOgrenci.cs dosyasini ekle
// Biz burada insert , update, delete, select islemlerini yapacagiz
// ExecuteNonQuery -> insert, update, delete islemleri icin kullanilir, ve verileri dondurur