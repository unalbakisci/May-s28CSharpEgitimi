﻿using System;
using System.Collections.Generic;
using System.Data.Entity; // entity framework kütüphanesi
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppEFCodeFirst.Entities;

namespace WindowsFormsAppEFCodeFirst
{
    internal class ProductDal // Dal = Data Access Layer (Veri Erişim Katmanı) - Ürünlerin veritabanı işlemlerinin yapıldıgı sınıf
    {
        public List<Product> GetAll()
        {
            using (UrunDbContext context = new UrunDbContext())//entity framework üzerinden db işlemlerini yapabilmek için
            {
                return context.Products.ToList();//GetAll metodunun çağrrıldığı yere ürün listesini döndür
            }
        }
        public int Add(Product product)
        {
            using (UrunDbContext context = new UrunDbContext())
            {
                var urun = context.Entry(product);
                urun.State = EntityState.Added;
                return context.SaveChanges();
            }
        }
        public Product Find(int id) // Find metodu kendisine gönderilecek id ile eşleşen kaydı bulur
        {
            using (UrunDbContext context = new UrunDbContext())

            {
                return context.Products.Find(id);
            }
        }
        public int Update(Product product)
        {
            using (UrunDbContext context = new UrunDbContext())
            { 
                var urun = context.Entry(product);
                urun.State = EntityState.Modified; // Modified:Güncellenecek
                return context.SaveChanges();
            }
        }
        public int Delete(Product product)
        {
            using (UrunDbContext context = new UrunDbContext())
            {
                var urun = context.Entry(product);
                urun.State = EntityState.Deleted; // Deleted: Silinecek
                return context.SaveChanges();
            }
        }
    }
}
