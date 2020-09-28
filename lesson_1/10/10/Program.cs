using System;

namespace _10
{
/*
  4. Найдите сумму первых n натуральных чисел, которые делятся на 3 без остатка
*/
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("введите количество чисел");
			int a = Convert.ToInt32(Console.ReadLine());
			int i = 1;
			int sum = 0;
			while (a > 0)
			{
				if (i % 3 == 0)
				{
					sum = sum + i;
					--a;
					Console.Write(i + " ");
				}
				++i;
			}
			Console.WriteLine("\nСумма чисел = " + sum);
		}
	}
}
