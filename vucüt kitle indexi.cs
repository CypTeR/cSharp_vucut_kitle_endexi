using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boyanaliz
{
    class Program
    {
        /*
        AD: Mikail AKSU
        NO: 461
        Sınıf: 10/A
        Konu: Vücut Kitle İndexi.
            */


        static void Main(string[] args)
        {
            Console.WriteLine("Boyunuzu giriniz(cm): ");
            int boy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kilonuzu giriniz(kg): ");
            int kilo = Convert.ToInt32(Console.ReadLine());
            int sonuc=vki(boy,kilo);
            Console.WriteLine("Vücut kitle indeksiniz: {0}", sonuc);
            karar(sonuc);
            Console.ReadKey();

            
        }
        public static int vki (int a, int b )
        {
            sonuc=a/100*a;
            sonuc = sonuc / b;
            return sonuc;
        }
        public static void karar(int deger)
        {
            if (sonuc < 25)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("kilonuz normal.");
            }
            else if (sonuc > 25 && sonuc < 30)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("kilonuz fazla.");
            }
            else
                Console.WriteLine("kilonuz çok fazla");
        }
        
    }
}
