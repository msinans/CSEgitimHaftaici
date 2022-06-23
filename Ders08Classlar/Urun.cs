using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders08Classlar
{
    internal class Urun
    {
        public int Id;
        public string UrunAdi;
        public int Stok;
        public decimal Fiyat;
        public string Renk;
        public string Ozellikler;
        public Kategori Kategori; // Ürün class ı ile kategori class ı arasında bağlantı 
        public int KategoriId;






    }
}
