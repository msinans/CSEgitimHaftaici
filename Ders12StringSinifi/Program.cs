namespace Ders12StringSinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StringSinifi!");
            string degisken;
            char karakter = 'k';
            string metinlericin = "string sınıfı yan yana dizilmiş karakter dizisinden oluşur";
            Console.WriteLine(metinlericin);
            // Ornek1();

            Ornek2();
        }
        static void Ornek1()
        
        {
            string birMetin = "Ankara başkenttir.";
            String birSayi = "123456789";
            System.String tarih = "30.06.2022";

            /*Console.WriteLine("Bir isim yazınız");
            string s = Console.ReadLine(); */

            string s = "Cüneyt Arkın";

            Console.WriteLine("for ile s yi ekrana yazdırma");
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("s[" + i + "] = " + s[i]);
            }
            Console.WriteLine("foreach ile s yi ekrana yazdırma");
            foreach (var karakter in s)
            {
                Console.WriteLine(karakter);
            }
            
            static void Ornek2()
            {
                string metin = "String metotları ile metin düzenleme işlemleri";
                Console.WriteLine(metin);
                Console.WriteLine("Metin uzunluğunu bul : " + metin.Length);
                Console.WriteLine("Metin i ile mi bitiyor? " + metin.EndsWith("i"));
                Console.WriteLine("Metin i ile mi başlıyor? " + metin.StartsWith("i"));
                Console.WriteLine("Metin içindeki i karakteri " + metin.IndexOf("i"));
                Console.WriteLine("Metin içindeki son i karakteri nerede " + metin.LastIndexOf("i"));
                Console.WriteLine(metin.Insert(0, "Konumuz :")); //sonraan metne bir şey eklemek için Insert
                Console.WriteLine(metin.Substring(6,10)); // substring metni parçalamaya yarar Metnin 6. karakterinden başla ve 10 karakter al.
                Console.WriteLine(metin.ToLower()); // metin içindeki tüm karakterleri küçük harfe çevirir
                Console.WriteLine(metin.ToUpper());
                Console.WriteLine(metin.ToLower().Replace("ş", "s").Replace(" ", "-"));
                Console.WriteLine(metin.Remove(2,5)); //Metnin 2. karakterinden başla ve 5 karakter sil.


            }
        }
    }
}