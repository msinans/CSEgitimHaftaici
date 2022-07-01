namespace Ders15Kapsülleme
{
    // Metot kullanarak kapsülleme

    public class Bolum

    {
        private string bolumAdi;
        // Accessor (Getter)
        public string GetBolumAdi() // Bu metot çağrıldığında
        {
            return bolumAdi; // Yukarıdaki private BolumAdi değişkenini geriye gönder
        }
        // Mutator (Setter) - Ayarlayıcı
        public void SetBolumAdi(string parametre)
        {
            if (parametre == "İstemediğimizDeğer")
            {
                Console.WriteLine("Bu bizim pek" + parametre);
            }
            else bolumAdi = parametre;
        }
    }
    // Property kulanarak kapsülleme
      
    public class Fakulte
    {
        private string bolum;
        public string Bolum
        {
            get { return bolum; } // get bloğu içindeki return(dön) komutundan anlaşılacağı üzere geriye içerideki private tanımladığımız kapsüllenen bölüm değişkenine atanan veriyi döndürür
            set
            {
                if (value == "Yazılım Mühendisliği")
                {
                    Console.WriteLine("Üniversitemizde {0} bölümü bulunmamaktadır", value);
                }
                else bolum = value;

            } // set bloğu ise dışarıya açık Bolum değişkenine atana veriyi alıp içeride kapsüllediğimiz private bölüm değişkenine atar.
        }
    }

    // Yalnız okunur (Read Only Property)
    public class Universite
    {
        private string bolum;
        public Universite(string str) // kurucu metotta parametre alarak işlem yapıyoruz
        {
            bolum = str;
        }
        public string Bolum()
        {
            return bolum; // set bloğu kullanmadığımız için bu sadece okunur yani readonly olmuş olur
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kapsülleme - Encapsulation!");
            /*
            Bolum bolum = new ();
            Console.WriteLine("Bölüm adı giriniz :");
            var bolumAdi = Console.ReadLine();
            bolum.SetBolumAdi (bolumAdi);
            Console.WriteLine("Seçilen Bölüm :" + bolum.GetBolumAdi());
            */
            Fakulte fakulte = new();
            fakulte.Bolum = "Bilgisayar Mühendisliği"; // sol tarafa bir de yazılım mühendisliği yazıp çalıştıralım
            Console.WriteLine("Seçilen Bölüm :" + fakulte.Bolum);

            Universite universite = new("Yazılım Mühendisliği"); // burada kurucu metota bir değer yollamalıyız tırnaklar arasına yazdığımız gibi
            Console.WriteLine("Seçilen Bölüm :" + universite.Bolum());

        }
    }
}