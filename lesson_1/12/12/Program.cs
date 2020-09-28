using System;

namespace _12
{
	//6.	Даны натуральные числа n, m. Получить их общие делители.
	public class Program
	{
		public static void Main()
		{
			int n = 32;
			int m = 48;
			int i = 1;
			while (i < n || i < m)
			{
				if ((n % i == 0) && (m % i == 0))
				{
					Console.Write(i + " ");
				}
				i++;
			}
		}
	}
}
