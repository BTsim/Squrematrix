using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squrematrix
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                Rectangle rectangle = new Rectangle(i, i);
                Triangle triangle = new Triangle(i, i);
                Circle circle = new Circle(i);
                Console.Write(rectangle.area + " ");
                Console.Write(triangle.area + " ");
                Console.WriteLine(circle.area + " ");

            }
            Console.ReadLine();
        }
    }
}
