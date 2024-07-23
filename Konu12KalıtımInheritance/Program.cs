using Konu12KalitimInheritance;

namespace Konu12KalıtımInheritance
{
   class Arac
    {
        public string AracTuru;
        public void Kornacal()
        {
            Console.WriteLine("Kornaya Basıldı!");
        }
    }
    class Otomobil : Arac // : Arac ile arac sınıfından içindekileri miras alırız
    { // artık otomobil sınıfında arac sınıfındaki içeriklere sahibiz
        public string Marka { get; set; }
        public string Model { get; set; }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu12KalitimInheritance!");
            Arac arac = new();
            arac.AracTuru = "Araba";
            Console.WriteLine("arac.AracTuru : " + arac.AracTuru);
            Otomobil otomobil = new();
            otomobil.AracTuru = " Otomobil ";// Normalde Otomobil clasında AracTuru yok
            Console.WriteLine("otomobil.AracTuru : " + otomobil.AracTuru);
            otomobil.Kornacal(); // KornaCal metodu bir üst sınıf olan Arac sınıfından geliyor

            Console.WriteLine();

            Kategori kategori = new()
            {
                Name = "Elektronik",
                UstMenudeGoster = true,
                EklenmeTarihi = DateTime.Now,
            };

            if (kategori.UstMenudeGoster == true)
            {
                Console.WriteLine($"kategori bilgileri : \n Adı : {kategori.Name} - Ekleme Tarihi : {kategori.EklenmeTarihi}");
            }
            Console.WriteLine();

            Urun urun = new()
            {
                Name = "Klavye",
                Fiyat = 299,
                Kdv = 18,
                EklenmeTarihi = DateTime.Now
            };

            Console.WriteLine($"ürün Bilgileri");
            Console.WriteLine($"Adı : {urun.Name}");
            Console.WriteLine($"Fiyatı : {urun.Fiyat}");
            Console.WriteLine($"Kdv : {urun.Kdv}");
            Console.WriteLine($"Eklenme Tarihi : {urun.EklenmeTarihi}");
        }
    }
}
