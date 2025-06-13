using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer; // EntityLayer namespace'i eklenmeli BusinessLogicLayer icinde referance -> Add reference -> EntityLayer
using DataAccessLayer; // BusinessLogicLayer icinde DataAccessLayer namespace'ini kullanabilmek icin referans eklenmeli

namespace BusinessLogicLayer
{
    public class BLLOgrenci   // Business Logic Layer (BLL) katmanını temsil eder , public yapman lazim
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if(p.Ad !=  null && p.Soyad != null && p.Numara != null && p.Sifre != null && p.Fotograf != null) // Kontrol islemi yapar
            {
                return DALOgrenci.OgrenciEkle(p); // DataAccessLayer'daki OgrenciEkle metodunu cagirir
            }
            return -1; // Hata durumunda -1 dondur yada null durumda hic bir sey dondurmez
        }
        public static List<EntityOgrenci> BllListele()
        {
            return DALOgrenci.OgrenciLestesi();
        }
    }
}
// 8. BusinessLogicLayer icine BLLOgrenci.cs dosyasini ekle