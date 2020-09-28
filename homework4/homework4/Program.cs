using System;

namespace homework4
{
    public class Program
    {
        public static void Main()
        {
            double vklad = 1000;
            double P = 12.5;
            int K = 0;
            double S = vklad;
            double curr = S;
            do
            {
                curr = (S / 100) * P;
                S = S + curr;
                ++K;
            }
            while (S < 5000);
            Console.WriteLine(K);
            Console.WriteLine(S);
        }
    }
}
