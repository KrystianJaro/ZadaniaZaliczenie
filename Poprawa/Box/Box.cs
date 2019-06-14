using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    class Box
    {
        public double width;
        public double height;
        public double depth;

       
        private double volume;
        private double area;


        public void SetWidth(double width)
        {
            this.width = width;
        }

        public void SetHeight(double height)
        {
            this.height = height;
        }

        public void SetDepth(double depth)
        {
            this.depth = depth;
        }

       
        public double GetWidth()
        {
            return width;
        }

        public double GetHeight()
        {
            return height;
        }

        public double GetDepth()
        {
            return depth;
        }
        public double GetVolume()
        {
            volume = width * height * depth;
            return volume;
        }

        public double GetArea()
        {
            area = width * 2 + height * 2 + depth * 2;
            return area;
        }

        



    }
}
