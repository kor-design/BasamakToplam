using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rakamlarToplami
{
    class Program
    {
        static void Main(string[] args)
        {
            BASADON:
            Console.WriteLine("Ekrana bir milyona kadar bir sayı giriniz.");
            var sayi = Convert.ToInt32(Console.ReadLine());
            int birler = sayi % 10;
            int onlar = (sayi % 100)/10;
            int yüzler = (sayi % 1000) / 100;
            int binler = (sayi % 10000) / 1000;
            int onbinler = (sayi % 100000) / 10000;
            int yüzbinler = (sayi % 1000000) / 100000;
            int milyonlar = (sayi % 10000000) / 1000000;
            int sayideğerleritoplami = birler + onlar + yüzler + binler + onbinler + yüzbinler + milyonlar;
            Console.WriteLine("{0} sayısının rakamları toplamı {1} dir", sayi, sayideğerleritoplami);
            Console.WriteLine("başka işlem yapmak istiyorsanız 1 e basın.");
            char secim = Convert.ToChar(Console.ReadLine());
            if (secim == '1')
            {
                goto BASADON;
            }
            else
            {
                Environment.Exit(0);
            }
            Console.Read();

        }
    }
}
