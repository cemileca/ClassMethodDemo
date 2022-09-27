namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(@"Yapmak istediğiniz işlemi Seçiniz:
Müşteri Listele:  1
Müşteri Ekle:     2
Müşteri Sil:      3");
            int GirilenDeger = Convert.ToInt32(Console.ReadLine());

            #region MüşteriEKle


            Musteri[] musteriDizisi = new Musteri[4];

            for (int i = 0; i < 4; i++)
            {
                Musteri musteri = new Musteri();
                switch (i)
                {
                    case 0:
                        musteri.MusteriID = 1;
                        musteri.MusteriAdi = "Yeliz";
                        musteri.MusteriSoyadi = "Pınar";
                        break;
                    case 1:
                        musteri.MusteriID = 2;
                        musteri.MusteriAdi = "Ahmet";
                        musteri.MusteriSoyadi = "Demir";
                        break;
                    case 2:
                        musteri.MusteriID = 3;
                        musteri.MusteriAdi = "Ferid";
                        musteri.MusteriSoyadi = "Zengin";
                        break;
                    case 3:
                        musteri.MusteriID = 4;
                        musteri.MusteriAdi = "Niyazi";
                        musteri.MusteriSoyadi = "Konuk";
                        break;
                }
                musteriDizisi[i] = musteri;
            }

            //  Musteri[] musteriDizisi = { musteri, musteri1, musteri2, musteri3 };


            #endregion

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
                    int degerGir1 = Convert.ToInt32(Console.ReadLine());
                    if (degerGir1 == 1)
                        goto case 1;
                    else if (degerGir1 == 2)
                        goto case 2;
                    else if (degerGir1 == 3)
                        goto case 3;
                    else
                         Console.WriteLine("Sistemden çıkış yapıldı ve Kapatıldı");
                   
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
                    int degerGir2 = Convert.ToInt32(Console.ReadLine());
                    if (degerGir2 == 1)
                        goto case 1;
                    else if (degerGir2 == 2)
                        goto case 2;
                    else if (degerGir2 == 3)
                        goto case 3;
                    else
                        Console.WriteLine("Sistemden çıkış yapıldı ve Kapatıldı");
                   
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
                    int degerGir = Convert.ToInt32(Console.ReadLine());
                    if (degerGir == 1)
                        goto case 1;
                    else if (degerGir == 2)
                        goto case 2;
                    else if (degerGir == 3)
                        goto case 3;
                    else
                        Console.WriteLine("Sistemden çıkış yapıldı ve Kapatıldı");
                    break;

                default:
                    Console.WriteLine("Sistemden çıkış yapıldı ve Kapatıldı");
                    break;

            }

        }

    }
}