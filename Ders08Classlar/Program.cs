// See https://aka.ms/new-console-template for more information


public class Ev // C# ta class tanımlama
{
    public int KapiNo; // Sınıf değişkenleri oluşturma
    public string SokakAdi;
}

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sınıflar-Classes!");

            // 1. Yöntem
            Ev ev = new(); // ev sınıfından bir nesne oluşturduk

            ev.KapiNo = 1; // ev nesnesinin değişkenlerine değer atadık
            ev.SokakAdi = "Okul sokak";

            Console.WriteLine("Ev adresimiz : " + ev.SokakAdi + " sk. No :" + ev.KapiNo); // ev nesnesinin özelliklerini ekrana yazdırdık

            //2. Yöntem
            Ev yazlik = new()
            {
                SokakAdi = "Yalı kavak sokak",
                KapiNo = 18
            };

            Console.WriteLine($"Yazlık adresi : {yazlik.SokakAdi} sk. No:{yazlik.KapiNo} Bodrum/Muğla");

            Kurs kurs = new()
            {
                KursAdi = "Arı Bilgi",
                EgitimAdi = "Yazılım Uzmanlığı",
                KapiNo = 102,
                SinifMevcudu = 6
            };

            Console.WriteLine("Kurs Bilgilerim \n : Kurs Adı {0} Eğitim Adı : {1} Kapı No : {2}", kurs.KursAdi, kurs.EgitimAdi, kurs.KapiNo);

        }
    }
}

public class Kurs
{
    public int KapiNo;
    public string KursAdi;
    public string EgitimAdi;
    public int SinifMevcudu;
}