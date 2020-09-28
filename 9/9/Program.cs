using System;

namespace _9
{
    /*
 3.	Дано четырехзначное натуральное n. Верно ли, что это число содержит ровно две цифры 7?
 */
    public class Program
    {
        static bool seven(int a)
        {
            bool d = false;
            int b = 0;
            char c = '7';
            string A = Convert.ToString(a);
            for (int i = 0; i < 4; i++)
            {
                if (A[i] == c)
                {
                    b++;
                }
            }
            if (b == 2)
            {
                d = true;
            }
            return d;
        }
        public static void Main()
        {
            int a = 1277;
            int b = 1743;
            int c = 7127;
            Console.WriteLine(seven(a));
            Console.WriteLine(seven(b));
            Console.WriteLine(seven(c));
        }
    }
}
