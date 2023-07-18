using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLib
{
    public class Rectangle
    {
        public double Area(double hight, double width)
        {
            return hight * width;
        }


    }
    public class Square
    {
        public double Area(double length)
        {
            return length * length;
        }
    }

    public class Circle    
    {
        public double Area(double radius)
        {
            return Math.PI*radius*radius;
        }
    }

    public class Triangle
    {
        public double Area(double hight,double width)
        {
            return (hight * width)/2;
        }
    }
}
