using System;

namespace task1
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("given a system of linear equations of the type:\nA1 * X + B1 * Y = 0\nA2 * X + B2 * Y = 0");
            Console.WriteLine("Enter A1 and B1: ");

            try
            {
                Equations equations1 = new Equations(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Enter A2 and B2: ");
                Equations equations2 = new Equations(Console.ReadLine());
                SolutionEquarions(equations1, equations2);
            }

            catch(MyException my)
            {
                Console.WriteLine(my.message);
                Console.WriteLine(my.time);
            }
        }

        public static void SolutionEquarions(Equations equations1, Equations equations2)
        {
            int X, Y;
            if ((equations1.A == equations2.A) && (equations1.B == equations2.B))
            {
                if ((equations1.A > 0 && equations1.B < 0) || (equations1.A < 0 && equations1.B > 0))
                {
                    throw new MyException();
                }
                else
                {
                    X = equations1.B;
                    Y = -equations1.A;
                    equations1.Print();
                    equations2.Print();
                    Console.WriteLine($"\nX = {X}\nY = {Y}\n");
                    Console.WriteLine($"{equations1.A}*{X} + {equations1.B}*{Y} = 0");
                    Console.WriteLine($"{equations2.A}*{X} + {equations2.B}*{Y} = 0");
                }
            }
            else
            {
                throw new MyException();
            }
        }
    }
}
