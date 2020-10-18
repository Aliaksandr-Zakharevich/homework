using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class Rectangle : Figure
    {
        double A, B;
        public Rectangle(double A, double B)
        {
            name = "Rectangle";
            this.A = A;
            this.B = B;
        }
        public override double Perimetr()
        {
            double P = (A * 2) + (B * 2);
            return P;
        }

        public override double Square()
        {
            double S = A * B;
            return S;
        }
    }
}
