using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squrematrix
{
    class Rectangle : IFigure
    {
        public double sideA { get; set; }
        public double sideB { get; set; }
        public double area { get; set; }
        public Rectangle(double A, double B)
        {
            sideA = A;
            sideB = B;
            FigureArea();
        }
        public void FigureArea()
        {
            area = sideA * sideB;
        }

    }
}
