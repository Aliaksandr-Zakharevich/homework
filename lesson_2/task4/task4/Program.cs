using System;

namespace task4
{
    struct Request
    {
        string codeRequest;

        string client;

        DateTime date;

        string[] nameProduct;

        double resSum;

       public  Request (string codeRequest, string client, string[] nameProduct, double resSum)
        {
            this.codeRequest = codeRequest;

            this.client = client;

            date = DateTime.Now;

            this.nameProduct = nameProduct;

            this.resSum = resSum;
        }

        public void Print()
        {
            Console.WriteLine($"Code: {codeRequest}");

            Console.WriteLine($"Client: {client}");

            Console.WriteLine($"Date request: {date}");

            Console.Write("Name product: ");
            for(int i = 0; i<nameProduct.Length; i++)
            {
                Console.Write(nameProduct[i] + ", ");
            }

            Console.WriteLine($"\nSum request: {resSum}");
        }
    }
    class Program
    {
        static double summa(params double[] arr)
        {
            double res = 0;
            foreach(double i in arr)
            {
                res += i;
            }
            return res;
        }
        static void Main(string[] args)
        {
           Console.Write("Enter code request: ");
           string code = Console.ReadLine();

           Console.Write("Enter name: ");
           string nameClient = Console.ReadLine();

           Console.Write("Enter quentity product: ");
           int quantity = Convert.ToInt32(Console.ReadLine());

           string[] nameProducts = new string [quantity];

           double[] price = new double[quantity];

           for (int i = 0; i<quantity; i++)
           {
               Console.Write("Enter name product: ");
               nameProducts[i] = Console.ReadLine();

               Console.Write("Enter price product: ");
               price[i] = Convert.ToDouble(Console.ReadLine());
           }

           double resSum = summa(price);

           Request newRequest = new Request(code, nameClient, nameProducts, resSum);

           Console.WriteLine();
           newRequest.Print();
        }
    }
}
