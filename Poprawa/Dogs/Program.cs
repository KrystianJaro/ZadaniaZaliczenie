using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogs
{
    class Program
    {
        public class Dog
        {
            public uint LegsCount = 4;
            public virtual string Bark() => "Hau";

        }
        public class GermanShepherd : Dog
        {
            public override string Bark() => "woof";
            public virtual string Growl() => "grr";

        }

        public class Corgi : Dog
        {
            public new string Bark() => "yip";

        }

        public class Lablador : GermanShepherd
        {
            public new string Bark() => "Hrau";
            public override string Growl() => "Grryyr";
        }
        static void Main(string[] args)
        {
            GermanShepherd gshepherd = new GermanShepherd();
            Corgi corgi = new Corgi();
            Dog corgi1 = new Corgi();
            Lablador lablador = new Lablador();

            Console.WriteLine("Germanshepherd-Szczekanie:" + gshepherd.Bark() + " Warczenie:" + gshepherd.Growl());
            Console.WriteLine("Corgi:" + corgi.Bark());
            Console.WriteLine("Inny typ:" + corgi1.Bark());
            Console.WriteLine("Lablador-Szczekanie:" + lablador.Bark() + " Warczenie:" + lablador.Growl());


            Console.ReadKey();
        }
    }
}