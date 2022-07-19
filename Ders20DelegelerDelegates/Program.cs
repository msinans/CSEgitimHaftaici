namespace Ders20DelegelerDelegates
{
    public delegate void BasitDelege(); // Delege tanımlama işlemi
    internal class Program
    {
        static void Topla()
        {
            Console.WriteLine("10+8 : " + (10+8));
        }
        void Topla(int sayi1, int sayi2)
        {
            Console.WriteLine("Parametreli metot: ");
            Console.WriteLine(sayi1+sayi2);
        }
        delegate void ParametreliDelege(int a, int b);
        static void Main(string[] args)
        {
            Console.WriteLine("Delegeler-Deeegates!");
            Console.WriteLine("Delegeler metot işaret eden referanslardır");
            BasitDelege basitDelege = new(Topla); // Delege kullanarak metot çağırdık
            basitDelege();
            Program program = new Program();
            ParametreliDelege parametreliDelege = new(program.Topla);
            parametreliDelege(9, 9);

        }
    }
}