using System;

namespace homework3
{
    /*Дано целое число в диапазоне 100–999. Вывести строку-описание 
данного числа, например: 256 — «двести пятьдесят шесть», 814 — «восемьсот 
четырнадцать».*/
    public static class Program
    {
        static void numbers(int number1)
        {
            string number2 = null;

            switch (number1 - number1 % 100)
            {
                case 100:
                    number2 = "сто";
                    break;
                case 200:
                    number2 = "двести";
                    break;
                case 300:
                    number2 = "триста";
                    break;
                case 400:
                    number2 = "четыреста";
                    break;
                case 500:
                    number2 = "пятьсот";
                    break;
                case 600:
                    number2 = "шестьсот";
                    break;
                case 700:
                    number2 = "семьсот";
                    break;
                case 800:
                    number2 = "восемьсот";
                    break;
                case 900:
                    number2 = "девятьсот";
                    break;
            }

            if ((number1 % 100 > 10) && (number1 % 100 < 20))
            {
                switch (number1 % 100)
                {
                    case 11:
                        number2 = number2 + ' ' + "одиннадцать";
                        break;
                    case 12:
                        number2 = number2 + ' ' + "двенадцать";
                        break;
                    case 13:
                        number2 = number2 + ' ' + "тринадцать";
                        break;
                    case 14:
                        number2 = number2 + ' ' + "четырнадцать";
                        break;
                    case 15:
                        number2 = number2 + ' ' + "пятнадцать";
                        break;
                    case 16:
                        number2 = number2 + ' ' + "шестнадцать";
                        break;
                    case 17:
                        number2 = number2 + ' ' + "семнадцать";
                        break;
                    case 18:
                        number2 = number2 + ' ' + "восемнадцать";
                        break;
                    case 19:
                        number2 = number2 + ' ' + "девятнадцать";
                        break;
                }
            }

            else
            {
                switch (number1 % 100 - number1 % 10)
                {
                    case 10:
                        number2 = number2 + " " + "десять";
                        break;
                    case 20:
                        number2 = number2 + " " + "двадцать";
                        break;
                    case 30:
                        number2 = number2 + " " + "тридцать";
                        break;
                    case 40:
                        number2 = number2 + " " + "сорок";
                        break;
                    case 50:
                        number2 = number2 + " " + "пятьдесят";
                        break;
                    case 60:
                        number2 = number2 + " " + "шестьдесят";
                        break;
                    case 70:
                        number2 = number2 + " " + "семьдесят";
                        break;
                    case 80:
                        number2 = number2 + " " + "восемьдесят";
                        break;
                    case 90:
                        number2 = number2 + " " + "девяносто";
                        break;
                }

                switch (number1 % 10)
                {
                    case 1:
                        number2 = number2 + " " + "один";
                        break;
                    case 2:
                        number2 = number2 + " " + "два";
                        break;
                    case 3:
                        number2 = number2 + " " + "три";
                        break;
                    case 4:
                        number2 = number2 + " " + "четыре";
                        break;
                    case 5:
                        number2 = number2 + " " + "пять";
                        break;
                    case 6:
                        number2 = number2 + " " + "шесть";
                        break;
                    case 7:
                        number2 = number2 + " " + "семь";
                        break;
                    case 8:
                        number2 = number2 + " " + "восемь";
                        break;
                    case 9:
                        number2 = number2 + " " + "девять";
                        break;
                }
            }

            Console.WriteLine(number2);
        }

        public static void Main()
        {
            Random rand = new Random();

            int myNumber = rand.Next(100, 999);

            Console.WriteLine(myNumber);

            numbers(myNumber);
        }
    }
}
