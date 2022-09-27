using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassMetotDemo
{
    internal class MusteriManager
    {
       
        public void MusteriEkle(int musteriID, string MusteriAdi, string MusteriSoyadi)
        {
            Musteri YeniMusteriEkle= new Musteri();
            YeniMusteriEkle.MusteriID = musteriID;
            YeniMusteriEkle.MusteriAdi= MusteriAdi;
            YeniMusteriEkle.MusteriSoyadi= MusteriSoyadi;   
           
            // Önceden oluşturulmuş müşteri dizisine yeni müşteriyi ekle kodu burda olucak.

        }
        public void MusteriSil(int musteriID)
        {
            // musteriID ye göre Müsteriyi sil Kodu burda yazılır.
        }
        public void MusteriListele(Musteri[] Musteriler)
        {
            foreach (var Musteri in Musteriler)
            {
                Console.WriteLine("Müşteri ID: "+Musteri.MusteriID);
                Console.WriteLine("Müşteri Adı: "+Musteri.MusteriAdi);
                Console.WriteLine("Müşteri Soyadı: "+Musteri.MusteriSoyadi);

            }
        }
    }
}
