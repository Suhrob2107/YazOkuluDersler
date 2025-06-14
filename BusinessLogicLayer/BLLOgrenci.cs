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
            if (p.Ad != null && p.Soyad != null && p.Numara != null && p.Sifre != null && p.Fotograf != null) // Kontrol islemi yapar
            {
                return DALOgrenci.OgrenciEkle(p); // DataAccessLayer'daki OgrenciEkle metodunu cagirir
            }
            return -1; // Hata durumunda -1 dondur yada null durumda hic bir sey dondurmez
        }
        public static List<EntityOgrenci> BllListele() // 7. BLL icinde OgrenciListele metodunu olusturduk
        {
            return DALOgrenci.OgrenciLestesi(); // DataAccessLayer'daki OgrenciLestesi metodunu cagirir ve listeyi dondurur
        }
        public static bool OgrenciSilBLL(int p) // 8. BLL icinde OgrenciSil metodunu olusturduk
        {
            if (p != null) // Id'nin pozitif bir deger olmasi kontrolu yapar
            {
                return DALOgrenci.OgrenciSil(p); // DataAccessLayer'daki OgrenciSil metodunu cagirir
            }
            return false; // Hata durumunda -1 dondur yada null durumda hic bir sey dondurmez
        }
    }
}
// 8. BusinessLogicLayer icine BLLOgrenci.cs dosyasini ekle