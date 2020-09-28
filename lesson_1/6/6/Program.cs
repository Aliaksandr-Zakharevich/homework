using System;

namespace _6
{
	public class Program
	{
		public static void Main()
		{
			int number1 = 1;
			int number2 = 7;
			for (int i = number1; i <= number2; i++)
			{
				for (int j = 1; j <= number1; j++)
				{
					Console.Write(i + " ");
				}
				number1++;
				Console.WriteLine();
			}
		}
	}
}
