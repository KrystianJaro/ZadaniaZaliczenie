using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace ProgramZaliczenie
{
    public class Circle : Shape
    {
        public Point v1;
        public Point v2;
        public double Radius { get; set; }
       
        
        public override double Area()
        {
            Radius = Math.Sqrt(Math.Pow(v1.X - v2.X, 2) + Math.Pow(v1.Y - v2.Y, 2));
            return Math.PI * (Math.Pow(Radius, 2.0));
        }

        public override double Perimeter()
        {
            Radius = Math.Sqrt(Math.Pow(v1.X - v2.X, 2) + Math.Pow(v1.Y - v2.Y, 2));
            return 2.0 * Math.PI * Radius;
        }
    }
}
