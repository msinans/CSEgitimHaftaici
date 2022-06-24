// See https://aka.ms/new-console-template for more information


/* C# nesne yönelimli bir programlama dili olduğu için her şey sınıflar içinde tanımlanır. Sınıflara ve sınıf öğelerine erişim kısıtlanabilir veya belirli düzeylerde erişime izin verilebilir. 
 Öğelere erişimi kısıtlayan ya da yetki veren anahtar sözcüklere "Erişim Belirteçleri (Access Modifiers)" denir.
    * Erişim Belirteçleri 4 ana sınıfa ayrılır.
    * public    : Erişim kısıtı yoktur, her yerden erişilebilir.
    * protected : Ait olduğu sınıftan ve o sınıftan türetilen sınıflardan erişilebilir.
    * internal  : Etkin projeye ait sınıflardan erişilebilir., onların dışında erişilemez.
    * private   : Yalnızca bulunduğu sınıftan erişilebilir, dıştaki sınıflardan erişilemez.
    * Bir öğe yalnızca 1 erişim belirteci alabilir.
    * namespace erişim belirteci almaz çünkü o daima public tir.
    * Sınıflar public veya internal nitelemesi alabilirler ama protected ya da private nitelemesi alamazlar.
    * enum erişim belirteci almaz çünkü daima public tir.
    */

using Ders08Classlar;
public class Deneme
{
    public string UrunAdi = "Bu değişkene herkes erişebilir public olduğu için";
}
internal class Test
{
    string UrunAdi = "Klavye";
}
namespace Ders09ErisimBelirleyiciler
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Erişim Belirleyiciler!");

            Kullanici kullanici = new();
            kullanici.Adi = "Taha";
            kullanici.Soyadi = "Çağlar";
            //kullanici.

            Console.WriteLine("Kullanici Bilgileri");
            Console.WriteLine($"Adı :{kullanici.Adi} - Soyadı :{kullanici.Soyadi}");

            SiniftaMetotKullanimi siniftaMetotKullanimi = new();
            siniftaMetotKullanimi.ToplamaYap();

        }
    }
}