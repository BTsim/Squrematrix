using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squrematrix
{
    class Triangle : IFigure
    {
        public double sideA { get; set; }
        public double height { get; set; }
        public double area { get; set; }
        public Triangle(double a, double h)
        {
            sideA = a;
            height = h;
            FigureArea();

        }
        public void FigureArea()
        {
            area = sideA * height / 2;
        }
    }
}
