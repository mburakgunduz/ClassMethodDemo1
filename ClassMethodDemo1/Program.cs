using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.isim = "Mehmet Burak";
            musteri1.soyisim = "Gündüz";
            musteri1.yas = 29;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.isim = "Merve";
            musteri2.soyisim = "Bingöl";
            musteri2.yas = 21;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.isim = "Fatma Banu";
            musteri3.soyisim = "Gündüz";
            musteri3.yas = 27;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Listele(musteriler);

            musteriManager.Sil(musteri2);

            musteriManager.Ekle(musteri1);

            Console.ReadKey();
        }
    }
}
