using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class Foursquare : Figure
    {
        double A;
        public Foursquare(double A)
        {
            name = "Foursquare";
            this.A = A;
        }

        public override double Perimetr()
        {
            double P = A * 4;
            return P;
        }

        public override double Square()
        {
            double S = A * A;
            return S;
        }
    }
}
