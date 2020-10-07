using System;

namespace task2
{
    struct Client
    {
        string codeOfClient;
        string firstName;
        string lastName;
        string address;
        string phone;
        int numderOrder;
        double sumOrder;

        public Client(string code, string firstName, string lastName, string address, string phone, int number, double sum)
        {
            codeOfClient = code;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.phone = phone;
            numderOrder = number;
            sumOrder = sum;
        }
        public void Print()
        {
            Console.WriteLine($"Code: {codeOfClient}");
            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Phone number: {phone}");
            Console.WriteLine($"The numder of Order: {numderOrder}");
            Console.WriteLine($"Total customer orders : {sumOrder}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string code = "01fx0ew";
            string firstName = "Alex";
            string lastName = "Black";
            string address = "K.Marksa st. 32";
            string phone = "8(025)123-45-67";
            int numberOrder = 3;
            double sum = 854.65;

            Client Alex = new Client(code, firstName, lastName, address, phone, numberOrder, sum);

            Alex.Print();
        }
    }
}
