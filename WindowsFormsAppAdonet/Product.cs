﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppAdonet
{
    public class Product
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public decimal UrunFiyati { get; set; }
        public int StokMiktari { get; set; }
        public bool Durum {  get; set; }
    }
}
