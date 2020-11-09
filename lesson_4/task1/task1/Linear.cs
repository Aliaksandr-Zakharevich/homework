using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class Linear
    {
        int A;
        int B;

        public Linear(string value)
        {
            string[] _value = Parse(value);
            if (_value.Length == 2)
            {
                A = Convert.ToInt32(_value[0]);
                B = Convert.ToInt32(_value[1]);
            }
            else
            {
                A = Convert.ToInt32(_value[0]);
                B = Convert.ToInt32(_value[2]);
            }
        }
        public static string[] Parse(string userInput)
        {
            string[] userValue = userInput.Split(" ,.".ToCharArray());
            return userValue;
        }
        public void Print()
        {
            Console.Write($"{A}*X + {B}*Y = 0");
        }
    }
}
