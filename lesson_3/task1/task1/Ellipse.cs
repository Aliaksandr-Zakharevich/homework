using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class Ellipse : Figure
    {
        double a, b;
        public Ellipse(double a, double b)
        {
            name = "Ellipse";
            this.a = a;
            this.b = b;
        }
        public override double Perimetr()
        {
            double L = Square() + Math.Pow(a - b, 2);
            L = L / (a + b);
            return L;
        }

        public override double Square()
        {
            double S = Math.PI * a * b;
            return S;
        }
    }
}
