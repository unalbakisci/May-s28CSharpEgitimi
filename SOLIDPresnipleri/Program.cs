﻿namespace SOLIDPresnipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SOLID Presnipleri!");
            /*
             * Robert Cecil Martin tarafından öne sürülen geliştirilecek yazılımın esnek, yeniden kullanılabilir, sürdürülebilir ve anlaşılır olmasını hedefleyen, kod tekrarını önleyen prensipler bütünüdür.
             */
            Console.WriteLine("S - Simg-Responsibility Principle");
            Console.WriteLine("Bir sınıf veya metodun sadece 1 sorumluluğunun olmasıdır");
            Console.WriteLine("0 - Open-Closed principle");
            Console.WriteLine("Bir sınıf ya da fonksiyon halihazırda var olan özellikleri korumalı ve değişikliğe izin vermemelidir");
            Console.WriteLine("L -  Liskov substitıtion Principle");
            Console.WriteLine("Kodlarımızda herhangi bir değişiklik yapmaya gerek duymadan alt sınıfları, türedikleri(üst) sınıfların yerine kullanabiliriz.");
            Console.WriteLine("I - Interface Segregation Principle");
            Console.WriteLine("Sorumlulukların hepsini tek bir arayüze toplamak yerine daha özelleştirilmiş birden fazla arayüz oluşturmalıyız.");
            Console.WriteLine("D - Dependency Inversion Principle");
            Console.WriteLine("Sınıflar arası bağımlılıklar olabildiğince az olmalıdır özellikle üst seviye sınıflar alt seviye sınıflara bağımlı olmamalıdır");
        }
    }
}
