using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppEFCodeFirst.Entities;

namespace WindowsFormsAppEFCodeFirst
{
    internal class ProductDal
    {
        public List<Product> GetAll()
        {
            using (UrunDbContext context = new UrunDbContext())//entity framework üzerinden db işlemlerini yapabilmek için
            {
                return context.Products.ToList();//GetAll metodunun çağrrıldığı yere ürün listesini döndür
            }
        }
    }
}
