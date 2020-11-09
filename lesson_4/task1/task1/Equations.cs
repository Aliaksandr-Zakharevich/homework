using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class Equations
    {
        public int A;
        public int B;

        public Equations(string value)
        {
            string[] _value = Parse(value);
            if (_value.Length == 2)
            {
                A = Convert.ToInt32(_value[0]);
                B = Convert.ToInt32(_value[1]);
            }
            else if (_value.Length == 3 && _value[2] != " ")
            {
                A = Convert.ToInt32(_value[0]);
                B = Convert.ToInt32(_value[2]);
            }
            else
            {
                throw new MyException();
            }
        }
        public static string[] Parse(string userInput)
        {
            string[] userValue = userInput.Split(" ,.".ToCharArray());
            return userValue;
        }
        public void Print()
        {
            Console.Write($"{A}*X + {B}*Y = 0\n");
        }
    }
}
