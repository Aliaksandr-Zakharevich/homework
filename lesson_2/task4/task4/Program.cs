using System;

namespace task4
{
    enum PayType
    {
        card = 1,
        cash,
        online
    }
    struct Request
    {
        string codeRequest;
        string client;
        DateTime date;
        string[] nameProduct;
        double resSum;
        PayType pay;

       public  Request (string codeRequest, string client, string[] nameProduct, double resSum, PayType pay)
        {
            this.codeRequest = codeRequest;
            this.client = client;
            date = DateTime.Now;
            this.nameProduct = nameProduct;
            this.resSum = resSum;
            this.pay = pay;
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
            Console.WriteLine($"Type paymant: {pay}");
        }
    }
    class Program
    {
        static PayType PaymantType(int payType)
        {
            PayType example = PayType.cash;

            if((int)example < payType)
            {
                return PayType.online;
            }
            else if((int)example> payType)
            {
                return PayType.card;
            }
            else
            {
                return PayType.cash;
            }
        }
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
            string code = "01fxe32rj";
            string nameClient = "Alex";

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

            Console.WriteLine("\nPayment Methods:\n1 - card\n2 - cash\n3 - online");
            Console.Write("Сhoose your preferred payment method: ");

            int payType = Convert.ToInt32(Console.ReadLine());
            PayType pay = PaymantType(payType);

           double resSum = summa(price);

           Request newRequest = new Request(code, nameClient, nameProducts, resSum, pay);

           Console.WriteLine();
           newRequest.Print();
        }
    }
}
