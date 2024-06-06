namespace Konu01Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Değişkenler!");

            Console.WriteLine(); // cw yaz tab a bas.Bu Şekilde içini boş bırakırsak ekranda boş satır oluşturur
            /*
               çoklu 
               yorum 
               satırı
             */
            Console.WriteLine("Tam Sayı Veri Tipleri      ");

            byte plaka_kodu;//0 - 255 tamsayı
            plaka_kodu = 18; // ddeğişkene değer atama 

            Console.WriteLine("plaka_kodu: " + plaka_kodu);

            sbyte sbyteTuru = 127;// +127 ile -128 arası değer alabilir
            short kısa = 32767; // -32768 ile +32767 arası değer alabilir
            ushort birazuzun = 65535; //0 - 65535
            int tamsayi = -2147483648;// 32 bit 4byte +2147483647 -2147483648
            uint uzuntamsayi = 4567892;// 0 - 4294967295
            long dahauzuntamsayı = 923372036854775887;
            ulong enuzuntamsayı = 18446744073709551615;
            
            int tamsayi2 = 5718; //degişken belirleme kuralı : int değişkeninin veri tipi, tamsayi2: değişkeninin adı , = 5718 değişkenin değeri, ; kodun bittiğini gösterir.

            //Kesirli Sayı Değişken Tipleri
            float kesirliSayi = 4.5f; //4byte yer kaplar 6-7 basamak
            double kesirliSayi2 = 4.5; //8byte yer kaplar 15 - 16 basamak

            //Decimal Veri Tipi
            decimal UrunFiyati = 550; //12byte, duyarlı basamak 28 - 29 

            //Char Veri Tipi
            char karater = 'ç';//char sadece 1 tane değer alır ve tek tırnaK içine yazılır

            //String Veri Tipi
            string degisken;
            string degisken1, degisken2;
            string metin = "string veri tipinde \n \t tüm karakterleri kullanabiliriz";// \n metinde kendinden sonraki alanın bir alt sattırdan devam eetmesini, \t ise klavyeden tab tuşuna basmış gibi metni ileri iter

            
            Console.WriteLine("metin içeriği: " + metin);

            //Boolean Veri Tipi
            //Geriyi true veya false dönen veri tipidir , 1byte lık yer kaplar
            bool islemSonuc = true;
            bool durum = false;

            //var ile değişken oluşturma

            var birdegisken = 18; //var ile oluşturulan değişkenlerde değişkenin veri tipi c# tarafından değişkene atanan değere göre otomatik algılanır
            var strmetin = "string metin";
            // strmetin = true; //strmetin değişkeninin tipi var tarafından string olarak belirlendikten sonra bool gibi farklı bir tipte veri atanamaz artık bu değişkene.

            var sonuc = false;
            sonuc = true;
            // sonuc = 18; // var ile tanımlanan nesneye farklı tipte veri atanamaz!

            Console.WriteLine("object veri tipi");
            object nesne = "bu bir nesnedir"; //Bu değişken türüne her türden veri atanabilir.
            Console.WriteLine(nesne +"-Tipi: " + nesne.GetType());
            nesne = 18; //object ile tanımlanan nesne değiştirilebilir
            Console.WriteLine(nesne + "-Tipi: " + nesne.GetType()); //GetType metodu bir nesnenin veri tipini bize getirir.

            //C# ta sabit tanımlama
            const int kdvOrani = 18;//sabitleri const olarak tanımlayıp program içerisinde kullanabiliriz, sabitlerin değeri tanımlandığı yerde verilir sonradan değişmez
            const int iskonto = 25;
            //kdvOrabi = 25; // sabitlerin değeri bu şekilde sonradan değiştirilmez!

            Console.WriteLine("Uygulanan İskonto Orabı: " + iskonto);
            Console.WriteLine("Ekrana Bir Şey Yazıp Enter a Basınız:");
            var deger = Console.ReadLine();//bu komut ekrandan girilen  1 satırlık veri yakalamamızı sağlar
            Console.WriteLine("Girdiğiniz Değer : " + deger);

        }
    }
}
