using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriNo+" nolu "+ musteri.Ad+" "+musteri.Soyad+ " isimli musteri sisteme eklendi");

        }

        public void Listele(Musteri musteri)
        {

            Console.WriteLine(musteri.Ad); 
           
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriNo + " nolu " + musteri.Ad + " " + musteri.Soyad + " isimli musteri sistemden silindi");
            musteri.Ad = "-";
        }

    }   

}
