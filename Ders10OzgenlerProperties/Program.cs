namespace Ders10OzgenlerProperties
{
    class Skorlar
    {
        private int skor;
        public int Skor // klasik property yapısı
        {
        get { return skor; } // get bloğu yukarıdaki skor değişkeninin değerini döndürür
        set { skor = value; } // set bloğu ise yukarıdaki skor değişkenine değer atamayı sağlar.
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Özgenler-Properties!");
            Skorlar skorlar = new Skorlar();
            skorlar.Skor = 5; // skorlar nesnesinin Skor özelliğine değer ata (Set bloğu çalışır) 

            Console.WriteLine("Skor Değeri : " + skorlar.Skor); // skorlar nesnesinin Skor özelliğinin değerini oku ve ekrana yaz (Get bloğu çalışır)

        }
    }
}