﻿namespace Konu13KapsullemeEncapsulation
{
    public class Bolum
    {
        private string BolumAdi; // dışarıdan erişime kapalı değişkenimiz.
        //Accessor (Getter)
        public string GetBolumAdi() // Geriye private BolumAdi değişkenini döndüren metot 
        {
            return BolumAdi; 
        }

        // Mutator (Setter)
        //public void SetBolumAdi(string a ) { BolumAdi = a ; }// Dışarıdam aldığı a parametresini BolumAdi değişkenine atayan metot
        public void SetBolumAdi(string istenenEğitimi)
        {
            if (istenenEğitimi == "Yazılım Mühendisliği")
            {
                Console.WriteLine("Üniversitemizde {0} bölümü bulunmamaktadır!", istenenEğitimi);
            }
            else BolumAdi = istenenEğitimi;
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu13KapsullemeEncapsulation!");

            Console.WriteLine("Kurumumuzdaki Bölümler:");
            Console.WriteLine("1-Elektronik");
            Console.WriteLine("2-Bilgisayar Mühendisliği");
            Console.WriteLine("3- Grafik Tasarım");

            Console.WriteLine("Lütfen Kaydolmak İstediğiniz Bölüm Adını Giriniz;");
            //Ornek1MetotlaKapsulleme();
            Ornek2ProplaKapsulleme();
        }
        static void Ornek1MetotlaKapsulleme()
        {
            Bolum bolum = new Bolum();
            var bolumAdi = Console.ReadLine();//ekrandan alınan değeri okuyup var ile olusturduguuz bolumadı değişkenine atadık
            bolum.SetBolumAdi(bolumAdi);//bolum içerisindeki SetBolumAdi metoduna bölüm adını gönderdik, private değişkene atama yapıldı
            Console.WriteLine("Bölüm adı : " + bolum.GetBolumAdi());//bolum içerisindeki GetBolumAdi() metodunu direk ekrana yazdırdık çünkü GetBolumAdi()
            Console.WriteLine("İşlemi Onaylıyor Musunuz?");
            Console.WriteLine("Evet/Hayır");
            var onayDurum = Console.ReadLine();
            if (onayDurum.ToLower() == "evet") //ToLower() metodu ekrandan gelecek metni küçük harfe çevirir.ufak harf buyuk hharf duyarlılıgını kaldırmak için.
            {
                Console.WriteLine("Kaydınız Başaryla Tamamlanmıştır..Aramıza Hoşgeldiniz..");
            }
            else
            {
                Console.WriteLine("Kayıt İşlemi İpital Edildi");
            }
        }
        static void Ornek2ProplaKapsulleme()
        {
            Fakulte fakulte = new Fakulte();
            fakulte.Bolum = Console.ReadLine();

            Console.WriteLine("Kayıt Olunacak Bölüm Adı {0} {1}", fakulte.Bolum, "2.değer");
        }
     }
     //Özgen (Property) kullanarak kapsülleme
     public class Fakulte
    {
        private string bolum;//Fakülte sınıfının içindeki bolum değişkenini private tanımlayarak kapsüllemiş olduk, böylece bu değişkene sadece aşağıdaki get, set metotlarıyla erişilebilir
        public string Bolum
        {
            get { return bolum; }//get bloğu içindeki return (dön) komutundan anlaşılacağı üzere geriye içerdeki private tanımladığımız kapsüllenen bolum değişkenine atanan veriyi döndürür
            set
            {
                if (value == "Yazılım Mühendisliği")
                {
                    Console.WriteLine("Üniversitemizde {0} bölümü bulunmaktadır!", value);
                    return;
                }
                else bolum = value;
            }//set bloğu ise dışarıya açık Bolum değişkenine atanan veriyi alıp içerde kapsullediğimiz private bolum değişkenine atar
        }
    }
}
