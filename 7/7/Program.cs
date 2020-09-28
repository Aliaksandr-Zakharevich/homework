using System;

namespace _7
{
 /* Дано целое число N большее 0. Найти число, полученное при прочтении числа N справа налево.*/
    public class Program
    {
        public static void Main(string[] args)
        {
            int N = 123;
            string A = Convert.ToString(N);
            for (int i = A.Length - 1; i >= 0; i--)
            {
                Console.Write(A[i]);
            }
        }
    }
}
