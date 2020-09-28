using System;

namespace homework5
{
	/*2.	Определить число, полученное выписыванием в обратном порядке цифр
четырехзначного натурального числа n.
*/
	public class Program
	{
		public static void Main()
		{
			int numder = 4321;
			string stringInvertedNumber = null;
			string stringNumber = Convert.ToString(numder);
			Console.WriteLine(stringNumber);
			for (int i = stringNumber.Length - 1; i >= 0; i--)
			{
				stringInvertedNumber = stringInvertedNumber + stringNumber[i];
			}
			Console.WriteLine(stringInvertedNumber);
			int invertedNumber = Convert.ToInt32(stringInvertedNumber);
			Console.WriteLine(invertedNumber);
		}
	}
}
