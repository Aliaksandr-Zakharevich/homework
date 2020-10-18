using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class Trapezoid : Figure
    {
        double A, B, C, D, H;
        public Trapezoid(double A, double B, double C, double D, double H)
        {
            name = "Trapezoid";
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.H = H;
        }

        public override double Perimetr()
        {
            double P = A + B + C + D;
            return P;
        }

        public override double Square()
        {
            double S = (A + B) / 2;
            return S * H;
        }
    }
}
