using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zad4
{
    public class Program 
    {
       
        static void Main(string[] args)
        {
            

            const string filepath = "test.txt";
            try
            {
                
                Console.WriteLine("Podaj wartosc przesuniecia");
                int k = int.Parse(Console.ReadLine());
                Cesar cesar = new Cesar(filepath);
                
                if (File.Exists(filepath))
                {
                    Console.WriteLine("Podaj tekst do zaszyfrowania");
                    string s = Console.ReadLine();
                    Console.WriteLine("Zaszyfrowana wiadomosc " + cesar.Coding(s, k));
                    cesar.Dispose();
                }
                else
                {
                    Console.WriteLine("Brak pliku");

                }
                Cesar cesar1 = new Cesar(filepath);
                Console.WriteLine("Odszyfrowana wiadomosc: " + cesar1.Encoding(k));
                cesar1.Dispose();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();

        }

    }
    
}
