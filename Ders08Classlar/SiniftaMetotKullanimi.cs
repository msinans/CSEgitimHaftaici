using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders08Classlar
{
    public class SiniftaMetotKullanimi
    {
        public string mesaj = "";
        public SiniftaMetotKullanimi() // klavyeden ctor yazıp iki kere taba tasarak oluşturduk
        {
            // Burası constructor (yapıcı-kurucu) metot : kurucu metotlar classlar new lendiği anda çalışan metotlardır. Böylece bir class tan nesne oluştuğu anda bir işlem yapmamızı sağlar.
            mesaj = "Kurucu metot çalıştı";
            Console.WriteLine(mesaj);
        }
    public void ToplamaYap() // classlar içerisinde metotlar tanımlayabiliriz böylece tekrar eden kodlarıtoparlayıp kod tekrararını engelleyebiliriz
    {
        Console.WriteLine(10+8);
    }
        public static void StatikToplamaYap(int sayi1, int sayi2) // Sınıflarda statik metot kullanımı 
        {
            Console.WriteLine(sayi1 + sayi2); // parametreden gönderilecek sayıları topla ve sonucu ekrana yazdır
         }
        public static string StatikDegisken = "Statik değişkenlere sınıfadı. diyerek doğrudan ulaşabiliriz";

}
}
