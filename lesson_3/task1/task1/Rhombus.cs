using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class Rhombus : Figure
    {
        double A;
        double H;
        public Rhombus(double A, double H)
        {
            name = "Rhombus";
            this.A = A;
            this.H = H;
        }
        public override double Perimetr()
        {
            double P = A * 4;
            return P;
        }

        public override double Square()
        {
            double S = A * H;
            return S;
        }
    }
}
