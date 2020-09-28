using System;

namespace _11
{
	//5.	Дано натуральное число n. Получить все его натуральные делители.
	public class Program
	{
		public static void Main()
		{
			int n = 33;
			int i = 1;
			while (i <= n)
			{
				if (n % i == 0)
				{
					Console.Write(i + " ");
				}
				i++;
			}
		}
	}
}
