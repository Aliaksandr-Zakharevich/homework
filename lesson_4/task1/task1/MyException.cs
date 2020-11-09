using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    public class MyException : ApplicationException
    {
        public string message;
        public DateTime time;
        
        public MyException()
        {
            message = "Error!\nInvalid input or no solution";
            time = DateTime.Now;
        }
    }
}
