namespace Ders14KalitimInheritance
{
    class Arac // Base class (ata sınıf)
    {
        public string AracTuru;
        public void AracKornasi()
        {
            Console.WriteLine("Doooooot");
        }
    }
    class Otomobil : Arac // Child Class
    {
        public string Marka { get; set; }
        public string Model { get; set; }
    }
    class Motosiklet : Arac // Motosiklet araç sınıfının bir alt türüdür
    {
        public string Marka { get; set; }
        public string Model { get; set; }
    }
    public class AtaSinif // Miras  alınacak olan baba sınıf
    {        // ctor Tab Tab
        public AtaSinif() // Kurucu metot, kurucu metotlar classlar ile aynı isimde olur ve class new lenerek bir yerde kullanılmak istenirse ilk çalışan metot kurucu ketottur, sonra class içindeki diğer metotlar çalışır.
        {
            Console.WriteLine("Ata sınıf kurucu metot çalıştı");
        }
        public void Yaz()
        {
            Console.WriteLine("Ata sınıftaki yaz metotu çalıştı");
        }
    }
    public class OgulSinif : AtaSinif
    {
        public OgulSinif()
        {
            Console.WriteLine("Oğul sınıf kurucu metot çalıştı");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalıtım(Miras Alma) - İnheritance!");
            Otomobil otomobil = new();
            otomobil.AracTuru = "Karayolu Taşıtı";
            otomobil.Marka = "Tofaşk";
            otomobil.Model = "Doğan SLX";
            otomobil.AracKornasi();
            Console.WriteLine($"Araç Bilgileri : Araç Türü : {otomobil.AracTuru} - Markası : {otomobil.Marka} - Modeli : {otomobil.Model}");
            Console.WriteLine();

            OgulSinif ogul = new();
            ogul.Yaz();

            Console.WriteLine();
            Console.WriteLine("Polimorfizm- Çok Biçimlilik");
            Cizici[] birCizici = new Cizici[4];
            birCizici[0] = new DogruCiz();
            birCizici[1] = new DaireCiz();
            birCizici[2] = new KareCiz();
            birCizici[3] = new Cizici();

            foreach (var item in birCizici)
            {
                item.Ciz();
            }


        }
    }

    // Polimorfizm(Çok Biçimlilik) : Bir fonksiyonun normal davranışının ezilerek farklı bir çıktı vermesini sağladığımız yöntem
    public class Cizici
    {
        public virtual void Ciz() // virtual ifadesi ile cic metodumuzu ezilebilir hale getirdik
        {
            Console.WriteLine("Çizici");
        }
    }

    public class DogruCiz : Cizici
    {
        public override void Ciz() // override ibaresi ile ciz metodumuzu ezerek farklı çıktı üretmesini sağladık
        {
            Console.WriteLine("Düz çizgi");
        }

    }
    public class DaireCiz : Cizici
    {
        public override void Ciz() // override ibaresi ile ciz metodumuzu ezerek farklı çıktı üretmesini sağladık
        {
            Console.WriteLine("Daire çizgi");
        }
    }
    public class KareCiz : Cizici
        {
            public override void Ciz() // override ibaresi ile ciz metodumuzu ezerek farklı çıktı üretmesini sağladık
            {
                Console.WriteLine("Kare çizgi");
            }
         }
    
}