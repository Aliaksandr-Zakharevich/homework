using System;

namespace _13
{
    /*
 7.	Даны натуральные числа m, n. Получить все натуральные числа меньшие n, квадрат суммы цифр которых равен m.

 */
    public class Program
    {
        static int getsum(int i)
        {
            int result = 0;
            while (i > 0)
            {
                result += i % 10;
                i /= 10;
            }
            return result;
        }
        public static void Main()
        {
            int n = 450;
            int m = 121;
            for (int i = 1; i < n; i++)
            {
                int j = getsum(i);
                if (Math.Pow(j, 2) == m)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
