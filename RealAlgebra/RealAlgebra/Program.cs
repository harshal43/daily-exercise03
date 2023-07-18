using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAreaLib;

namespace RealAlgebra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the process...\n1. Rectangle\n2. Square\n3. Circle\n4. Triangle");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    {
            Rectangle rectangle = new Rectangle();
                        Console.WriteLine("Enter the height");
                        int height = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the width");
                        int width = int.Parse(Console.ReadLine());
                        Console.WriteLine("Area of rectangle:\t" + rectangle.Area(height, width));
                        break;
                    }
                case 2:
                    {
                        Square sq = new Square();
                        Console.WriteLine("Enter the lenght");
                        int lenght = int.Parse(Console.ReadLine());
                        Console.WriteLine("Area of square:\t" + sq.Area(lenght));
                        break;
                    }
                case 3:
                    {
                        Circle cl = new Circle();
                        Console.WriteLine("Enter the radius");
                        int r = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Area of circle:\t" + cl.Area(r));
                        break;
                    }
                case 4:
                    {
                        Triangle tri = new Triangle();
                        Console.WriteLine("Enter the height");
                        int height = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the width");
                        int width = int.Parse(Console.ReadLine());
                        Console.WriteLine("Area of triangle\t" + tri.Area(height, width));
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
