namespace Ders19Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Events - Olaylar!");

            Product product = new(30);
            product.ProductName = "Monster Notebook";

            Product telefon = new(45);
            telefon.ProductName = "Ayfon";

            telefon.StockControlEvent += Telefon_StockControlEvent;

            Console.WriteLine("Satış yapmak için miktar giriniz: ");
            int satisMiktari = int.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                product.Satis(satisMiktari);
                telefon.Satis(satisMiktari);
                satisMiktari = int.Parse(Console.ReadLine());
            }
        }

        private static void Telefon_StockControlEvent()
        {
            Console.WriteLine("Dikkat telefon stokları tükeniyor");
        }
    }
}