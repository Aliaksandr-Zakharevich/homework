using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class Parallelogram : Figure
    {
        double A, B, H;
        public Parallelogram(double A, double B, double H)
        {
            name = "Parallelogram";
            this.A = A;
            this.B = B;
            this.H = H;
        }
        public override double Perimetr()
        {
            double P = (A * 2) + (B * 2);
            return P;
        }

        public override double Square()
        {
            double S = A * H;
            return S;
        }
    }
}
