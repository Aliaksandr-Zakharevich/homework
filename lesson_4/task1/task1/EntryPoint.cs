using System;

namespace task1
{
    /*
     Разработать собственный структурный тип данных для хранения целочисленных коэффициентов А и В
    линейного уравнения A*X + B*Y = 0. В классе реализовать статический метод Parse(), которые принимает 
    строку со значениями коэффициентов, разделенных запятой или пробелом
     */
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter linear:");
            Linear A1 = new Linear(Console.ReadLine());
            A1.Print();          
        }
    }
}
