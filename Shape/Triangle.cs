using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace ProgramZaliczenie
{
    public class Triangle : Shape
    {
        Point v1 { get; set; }
        Point v2 { get; set; }
        Point v3 { get; set; }

        private double length1;
        private double length2;
        private double length3;
        private double tarea;

        public override double Area()
        {
            tarea = (v1.X * (v2.Y - v3.Y) + v2.X * (v3.Y - v1.Y) + v3.X * (v1.Y - v2.Y)) / 2.0;
            return Math.Abs(tarea);

        }

        public override double Perimeter()
        {
            length1 = Math.Sqrt(Math.Pow((v1.X - v2.X), 2) + Math.Pow(v1.Y - v2.Y, 2));
            length2 = Math.Sqrt(Math.Pow((v2.X - v3.X), 2) + Math.Pow(v2.Y - v3.Y, 2));
            length3 = Math.Sqrt(Math.Pow((v3.X - v1.X), 2) + Math.Pow(v3.Y - v1.Y, 2));
            return length1 + length2 + length3;

        }
    }
}
