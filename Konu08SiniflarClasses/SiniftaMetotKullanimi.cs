namespace Konu08SiniflarClasses
{
    internal class SiniftaMetotKullanimi
    {
        string kurucuMetot;
        public SiniftaMetotKullanimi()//constructor kurucu metot : kısayou ctor > tab
        {
            kurucuMetot = "Sınıflarda constructor (kurucu metot) özelliği vardır ve  bu metotlar sınıftan bir nesne oluşturulduğunda otomatik olarak çalışır ve içerisindeki kodları çalıştırı.Kurucu metotlar değişkenler gibi veri tipi almazlar ve vopid ifadesi de bulunmaz, sııfın adıyla ay ad kullanılarak oluşturulur.";//yukarda tanımladığımız kurucu metot değişkenine sınıfımızın kurucu metodunda değer ataması yaptık
            Console.WriteLine(kurucuMetot);
            Console.WriteLine();
        }

        public bool LoginKontrol(string kullanici, string sifre)
        {
            if (kullanici == "admin" && sifre == "123456")
            {
                return true;
            }
            return false;
        }

        public int  ToplamaYap(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public bool MailBosmuDolumu(string mail)
        {
            if (!string.IsNullOrWhiteSpace(mail)) // IsNullOrWhiteSpace sstring metotlarından biridir kendisine gönderilen string degerin boş olup olmamasını kontrol eder
            {
                return true;
            }
            else return false;
        }

        public static string SinifDesgiskeni = "Sınıflarda metot ve değişkeb de kullanılabilir";
        public string DinamikDegisken = "Bu değişken statik değildir!";
    }
}
