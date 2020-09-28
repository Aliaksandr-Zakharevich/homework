using System;

namespace homework1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature in Pharyngeates");
            double Tf = Convert.ToDouble(Console.ReadLine());
            double Tc = (Tf - 32) * 5 / 9;
            Console.WriteLine("Temperature in Celsius: " + Tc);
        }
    }
}
