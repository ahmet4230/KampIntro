using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.MusteriAdi = "Engin";
            musteri1.MusteriSoyad = "Demiroğ";
            musteri1.TcNO = "1312";

            // GERÇEK - TÜZEL MÜŞTERİ birbirine benzer diye birbirlerinin özelliklerini kullanılamaz.SASD...
            // SOLID
            // Kodlama iO Tüzel müşteri
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "4545454";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "111111";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri4);



        }
    }
}
