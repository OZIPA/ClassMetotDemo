using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1= new Musteri();
            musteri1.Ad = "Ali";
            musteri1.Soyad = "Beyaz";
            musteri1.Id = 1;
            musteri1.KimlikNo = "123456789";
            musteri1.MusteriNo = "000120";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Veli";
            musteri2.Soyad = "Beyaz";
            musteri2.Id = 2;
            musteri2.KimlikNo = "123456780";
            musteri2.MusteriNo = "000121";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2};

            MusteriManager musteriManager= new MusteriManager();
            musteriManager.Ekle(musteri2);

            Console.WriteLine("Musteri Listesi:");
            foreach (var musteri in musteriler)
            {
                musteriManager.Listele(musteri);
            }


            musteriManager.Sil(musteri1);

            Console.WriteLine("Musteri Listesi:");
            foreach (var musteri in musteriler)
            {
                musteriManager.Listele(musteri);
            }






        }
    }
}
