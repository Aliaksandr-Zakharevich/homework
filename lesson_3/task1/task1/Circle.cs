using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class Circle : Figure
    {
        double r;
        public Circle(double r)
        {
            name = "Circle";
            this.r = r;
        }
        public override double Perimetr()
        {
            double L = 2 * Math.PI * r;
            return L;
        }

        public override double Square()
        {
            double S = Math.PI * Math.Pow(r, 2);
            return S;
        }
    }
}
