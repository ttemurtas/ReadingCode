using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tayfun Temurtaş
            GercekMusteri musteri = new GercekMusteri();
            musteri.Id = 1;
            musteri.MusteriNo = "12345";
            musteri.Ad = "Tayfun";
            musteri.Soyad = "Temurtaş";
            musteri.TcNo = "1234567890";

            // Kodlama.io
            TuzelMusteri tMusteri = new TuzelMusteri();
            tMusteri.Id = 2;
            tMusteri.MusteriNo = "54321";
            tMusteri.SirketAdi = "Kodlama.io";
            tMusteri.VergiNo = "1234567890";

            Musteri musteri2 = new GercekMusteri();
            Musteri musteri3 = new TuzelMusteri();
            

        }
    }
}
