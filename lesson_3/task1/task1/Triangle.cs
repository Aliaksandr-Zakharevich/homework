using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class Triangle : Figure
    {
        double A, B, C;
        public Triangle(double A, double B, double C)
        {
            name = "Triangle";
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public override double Square()
        {
            double pp = Perimetr() / 2;
            double S = pp*(pp - A)*(pp - B)*(pp - C);
            return Math.Sqrt(S);
        }

        public override double Perimetr()
        {
            double P = A + B + C;
            return P;
        }

    }
}
