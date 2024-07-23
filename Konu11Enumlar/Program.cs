namespace Konu11Enumlar
{
    internal class Program
    {
        // Enumlar (Numaratörler) lar nesneleri numaralandırmak için kullanılır
        /*
         *  Enum tipler üzerindeki kısıtlar
         *  1-Enum blokunda metot tanımlanamaz
         *  2-Arayüz (Interface) kullanamazlar
         *  3-enum blokunda oroperty kullanılmaz  
         * */
        enum Aylar : byte//byte koleksiyondaki numaraların veri tipinin byte türünden olacağını belirtiyor
        {
            Ocak, Şubat, Mart, Nisan, Mayıs, Haziran, Temmuz, Ağustos, Eylül, EKim, Kasım, Aralık
        }
        enum SiparisDurumu
        {
            Hazırlanıyor, Hazırlandı, KargoBekleniyor, Kargolandı
        }
        enum Meyveler : int
        {
            Elma = 3, Armut = 7, Çilek = 1
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Konu 11 Enumlar");
            byte a = (byte)Meyveler.Armut;
            byte b = (byte)Meyveler.Elma;
            byte c = (byte)Meyveler.Çilek;
            Console.WriteLine($"{Meyveler.Armut} = {a}, {Meyveler.Elma}={b}, {Meyveler.Çilek}={c}");

            Ornek1(SiparisDurum: 2);
        }
        static void Ornek1(int SiparisDurum)
        {
            if (SiparisDurum == (int)SiparisDurumu.Hazırlanıyor)
                Console.WriteLine("Sparisiniz Hazırlanıyor");
            if (SiparisDurum == (int)SiparisDurumu.Hazırlandı)
                Console.WriteLine("Sparisiniz Hazırlandı");
            if (SiparisDurum == (int)SiparisDurumu.KargoBekleniyor)
                Console.WriteLine("Sparisiniz İçin Kargo Bekleniyor");
            if (SiparisDurum == (int)SiparisDurumu.Kargolandı)
                Console.WriteLine("Sparisiniz Kargolandı");
        }
    }
}
