using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    class Complex
    {
        public int x, y;

        public Complex(int number1, int number2)
        {
            x = number1;
            y = number2;
        }

        public static Complex operator-(Complex z, Complex z1)
        {
            return new Complex(z.x - z1.x, z.y - z1.y);  
        }

        public static Complex operator -(Complex z, int number)
        {
            return new Complex(z.x - number, z.y);
        }

        public static Complex operator*(Complex z, Complex z1)
        {
            int intermediate1 = ((z.x * z1.x) - (z.y * z1.y));
            int intermediate2 = ((z.y * z1.x) + (z.x * z1.y));
            return new Complex(intermediate1, intermediate2);
        }

        public static Complex operator *(int number, Complex z)
        {
            return new Complex(z.x * number, z.y);
        }

        public static Complex operator/(Complex z, Complex z1)
        {
            int intermediate1 = ((z.x * z1.x) + (z.y * z1.y)) / ((z1.x*z1.x) + (z1.y*z1.y));
            int intermediate2 = ((z.y * z1.x) - (z.x * z1.y)) / ((z1.x * z1.x) + (z1.y * z1.y));
            return new Complex(intermediate1, intermediate2);
        }

        public void Print()
        {
            Console.Write($"{x} + {y}i");
        }
    }
}
