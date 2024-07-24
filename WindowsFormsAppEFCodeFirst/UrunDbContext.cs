using System;
using System.Collections.Generic;
using System.Data.Entity; //entity framework kütüphamesi
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppEFCodeFirst
{
    internal class UrunDbContext : DbContext // UrunDbContext  bizim veritabanı yönetim contextimiz, DbContext ise entity framework ün
    {
        public DbSet<Entities.Product> Products { get; set; }//Entity framework de veritabanı tablolarımızı programımızla eşleştiren kısım. //Products Sql  veritabanındaki Products tablosuna karsılık gelir.
        /*
         * Projede Entity framework kullanmak için yapılacaklar;
         * Projeye sağ tıklayıp açılan menüden Nuget yazana tıklayıp paket yönetici ekranını açıyoruz
         * Nuget penceresinde Browse sekmesine basıp oradan Entity framework ü sçip install diyerek yüklemeyi tamamlıyoruz.
         * Projeye Entity classlrımızı (Product, Category.. vb ) ekleyip içlerine propertyleri ekliyoruz
         * UrunDbContext sınıfımızı oluşturup Entity framework ün DbContext sınıfından kalıtımla bu şekilde tanımlıyoruz
         * UrunDbContext içine kaç Entity classsımızvars onları DbSet olarak yukardaki gibi tanımlıyoruz
         * ProductDal sınıfımızı olusturuyoruz ve içinde Entity framework ile veritabanı işlemleri yapan metotlarımızı hazırlıyoruz
         * Son olarak bu metotları ilgili ekranlarda çagırarak veritabanı CRUD işlemlerini yapıyoruz.
         */
    }
}
