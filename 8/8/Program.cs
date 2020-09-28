using System;

namespace _8
{
    /*
  1.	Определить, есть ли среди первых четырех цифр дробной части заданного положительного вещественного числа, цифра 5.
  */
    public class Program
    {
        static bool five(double a)
        {
            bool f = false;
            double b = a - (int)a;
            string N = Convert.ToString(b);
            if (N.Length < 6)
            {
                Console.WriteLine("Ошибка");
                return f;
            }
            char c = '5';
            for (int i = 0; i < 6; i++)
            {
                if (N[i] == c)
                {
                    f = true;
                    break;
                }
            }
            return f;
        }
        public static void Main()
        {
            double number1 = 5.432154;
            double number2 = 5.3245156;
            double number3 = 5.0;
            Console.WriteLine(five(number1));
            Console.WriteLine(five(number2));
            Console.WriteLine(five(number3));
        }
    }
}
