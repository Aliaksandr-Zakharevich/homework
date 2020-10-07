using System;

namespace task1
{
    //Описать структуру Article, содержащую поля код товара, название товара, цену товара
    class Program
    {
        struct Article
        {
            string codeOfProduct;
            string nameProduct;
            double priseProduct;

            public Article(string code, string name, double prise)
            {
                codeOfProduct = code;
                nameProduct = name;
                priseProduct = prise;
            }
            public void Print()
            {
                Console.WriteLine($"code: {codeOfProduct}, name: {nameProduct}, price: {priseProduct}");
            }
        }
        static void Main(string[] args)
        {
            string code = "0fx1456";
            string name = "Smartphone";
            double price = 134.632;
            Article a = new Article(code, name, price);
            a.Print();
        }
    }
}
