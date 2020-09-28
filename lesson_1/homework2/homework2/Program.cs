using System;

namespace homework2
{
    class Program
    {
        public class Triangle
        {
            double x1, y1;
            double x2, y2;
            double x3, y3;

            double A, B, C;

            public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
            {
                this.x1 = x1;
                this.y1 = y1;
                this.x2 = x2;
                this.y2 = y2;
                this.x3 = x3;
                this.y3 = y3;

                A = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
                B = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
                C = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
            }

            public double Perimetr()
            {
                double P = A + B + C;
                return P;
            }

            public double Square()
            {
                double PP = Perimetr() / 2;
                double S = PP * (PP - A) * (PP - B) * (PP - C);
                S = Math.Pow(S, 0.5);
                return S;
            }
        }
        static void Main(string[] args)
        {
            Triangle trianleOne = new Triangle(1, 1, 5, 1, 3, 6);
            Console.WriteLine(trianleOne.Perimetr());
            Console.WriteLine(trianleOne.Square());
        }
    }
}
