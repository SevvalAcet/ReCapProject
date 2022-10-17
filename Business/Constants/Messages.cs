using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
    
        internal static List<Brand> MaitenceTime;
        
        public static string BrandAdded = "Araba markası eklendi.";
        public static string BrandDeleted = "Araba markası silindi.";
        public static string BrandUpdated = "Araba markası güncellendi.";
        public static string BrandListed = "Markalar listelendi.";
        public static string BrandGet = "Marka getirildi.";
        public static string SameNameExist = "Aynı araba markası mevcut";

        public static string CarAdded = "Araba eklendi:";
        public static string CarDeleted = "Araba silindi.";
        public static string CarUpdated = "Araba bilgisi güncellendi.";
        public static string CarListed = "Arabalar listelendi";
        public static string CarNotAdded = "Araba Eklenemedi. Araba ismi geçersiz.";
        public static string CarNotUpdated = "Araba Güncellenemedi";
        public static string CarNotDeleted = "Araba Silinemedi";
        public static string CarCantFind = "Güncellenecek Araba bulunamadı";
        public static string CarDetailList = "Araba Detay Listesi";

        public static string CustomerAdded = "Yeni müşteri eklendi.";
        public static string CustomerDeleted = "Müşteri silindi.";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerListed = "Müşteriler listelendi.";
        public static string CustomerGet = "Müşteri bilgileri getildi.";

        public static string CustomerNotAdded = "Yeni müşteri eklenemedi.";
        public static string CustomerNotDeleted = "Müşteri silinemedi.";
        public static string CustomerNotUpdated = "Müşteri güncellenemedi";
        public static string CustomerNotListed = "Müşteriler listelenemedi.";
        public static string CustomerNotGet = "Müşteri bilgileri getilemedi.";

        public static string RentalAdded = "Araba kiralandı.";
        public static string RentalDeleted = "Kiralık araba silindi.";
        public static string RentalUpdated = "Kiralık araba güncellendi.";

        public static string RentalNotAdded = "Araba kiralanamadı.";
        public static string RentalNotDeleted = "Kiralık araba silinemedi.";
        public static string RentalNotUpdated = "Kiralık araba güncellenemedi.";

        public static string RentalListed = "Kiralık arabalar listelendi.";
        public static string RentalGet = "Kiralık araba getirildi.";
    }
}
