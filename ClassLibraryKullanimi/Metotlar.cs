using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryKullanimi
{
    public class Metotlar
    {
        public static bool MailGonder(string mail)
        {
            if (!string.IsNullOrWhiteSpace(mail))
            {
                // Burada mail gönderme kodları bulunur!
                return true;
            }
            else return false;

        }
        public void Topla()
        {
            Console.WriteLine("Topla Metodu");
            
        }
    }
}
