using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squrematrix
{
    class Circle : IFigure
    {
        public double radius { get; set; }
        public double area { get; set; }
        public Circle(double r)
        {
            radius = r;
            FigureArea();

        }
        public void FigureArea()
        {
            area = Math.PI * Math.Pow(radius, 2);
        }
    }
}
