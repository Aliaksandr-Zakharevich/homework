using System;

namespace task3
{
    struct RequestItem
    {
        string nameProduct;
        int numderOfItem;

        public RequestItem (string nameProduct, int numberOfItem)
        {
            this.nameProduct = nameProduct;
            this.numderOfItem = numberOfItem;
        }

        public void Print()
        {
            Console.WriteLine($"Item: {nameProduct} \nQuantity: {numderOfItem}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string product = "Printer";
            int quantity = 8;

            RequestItem printers = new RequestItem(product, quantity);
            printers.Print();
        }
    }
}
