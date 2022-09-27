namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MüşteriEKle


            Musteri musteri = new Musteri();
            musteri.MusteriID = 1;
            musteri.MusteriAdi = "Yeliz";
            musteri.MusteriSoyadi = "Pınar";

            Musteri musteri1 = new Musteri();
            musteri.MusteriID = 2;
            musteri.MusteriAdi = "Ahmet";
            musteri.MusteriSoyadi = "Demir";

            Musteri musteri2 = new Musteri();
            musteri.MusteriID = 3;
            musteri.MusteriAdi = "Ferid";
            musteri.MusteriSoyadi = "Zengin";

            Musteri musteri3 = new Musteri();
            musteri.MusteriID = 4;
            musteri.MusteriAdi = "Niyazi";
            musteri.MusteriSoyadi = "Konuk";

            Musteri[] musteriDizisi = { musteri, musteri1,musteri2,musteri3  };


            #endregion

                     Console.WriteLine(@"Yapmak istediğiniz işlemi Seçiniz:
Müşteri Listele:  1
Müşteri Ekle:     2
Müşteri Sil:      3");
            int GirilenDeger = Convert.ToInt32(Console.ReadLine());
            MusteriManager musteriYonet = new MusteriManager();

            switch (GirilenDeger)
            {
                case 1:
                    Console.Clear();
                    
                    musteriYonet.MusteriListele(musteriDizisi);

                    Console.WriteLine(@"
Yapmak istediğiniz işlemi Seçiniz:
Müşteri Listele:  1
Müşteri Ekle:     2
Müşteri Sil:      3
Ana menüye dön:   4
");
                    break;
                case 2:

                    musteriYonet.MusteriEkle(005, "Hayriye", "Solmaz");
                    Console.Clear();
                    Console.WriteLine("Hayriye Solmaz isimli Müşteri başarı ile eklendi.");
                    Console.WriteLine(@"
Yapmak istediğiniz işlemi Seçiniz:
Müşteri Listele:  1
Müşteri Ekle:     2
Müşteri Sil:      3
Ana menüye dön:   4
");
                    break;
                case 3:
                    Console.Clear();
                    musteriYonet.MusteriSil(001);
                    Console.WriteLine("Yeliz Pınar isimli Müşteri kaydı başarı ile silindi.");
                    Console.WriteLine(@"
Yapmak istediğiniz işlemi Seçiniz:
Müşteri Listele:  1
Müşteri Ekle:     2
Müşteri Sil:      3
Ana menüye dön:   4
");
                    break;

            }

        }

    }
}