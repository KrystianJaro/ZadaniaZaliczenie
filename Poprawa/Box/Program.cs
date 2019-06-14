using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Box
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalna_objetosc = 0;
            double maxvolume = 1200;


            Box box = new Box();
            int numer_boxa = 0;
            double dlugosc = 0;
            double wysokosc = 0;
            double szerokosc = 0;

            




            for (; ; )
            {


                List<Box> boxes = new List<Box>();
                numer_boxa = numer_boxa + 1;
                Console.WriteLine("Tworzenie box'a numer " + numer_boxa);
                Console.WriteLine("");
                Console.WriteLine("Podaj szerokość:");
                box.SetWidth(Convert.ToDouble(Console.ReadLine()));
                dlugosc = box.GetWidth();

                Console.WriteLine("Podaj wysokość:");
                box.SetHeight(Convert.ToDouble(Console.ReadLine()));
                wysokosc = box.GetHeight();

                Console.WriteLine("Podaj grubość:");
                box.SetDepth(Convert.ToDouble(Console.ReadLine()));
                szerokosc = box.GetDepth();
                boxes.Add(new Box() { width = dlugosc, height = wysokosc, depth = szerokosc });



                Console.WriteLine();
                Console.WriteLine("Objętość box'a numer " + numer_boxa + " to " + $"{box.GetVolume()}");
                Console.WriteLine("Pole powierzchni box'a numer " + numer_boxa + " to " + $"{box.GetArea()}");

                totalna_objetosc = totalna_objetosc + box.GetVolume();

                Console.WriteLine();
                Console.WriteLine();

                if (totalna_objetosc > maxvolume)
                {
                    Console.Beep(3000, 100);
                    Console.Beep(2800, 100);
                    Console.Beep(2600, 100);
                    Console.Beep(2400, 100);
                    Console.WriteLine(" Sumaryczna objętość przekroczyła wartość \n podaną przy uruchomieniu programu. ");
                    Console.ReadLine();
                    System.Environment.Exit(1);
                }




                Console.ReadLine();




            }





           
        }
    }
}
