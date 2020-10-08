using System;

namespace task1
{

    enum ArticleType
    {
        Smartphone = 1,
        TV,
        Iron,
        Rifregerator,
        Notebook,
        PC

    }
    class Program
    {
        struct Article
        {
            string codeOfProduct;
            string nameProduct;
            double priseProduct;
            ArticleType category;

            public Article(string code, string name, double prise, ArticleType category)
            {
                codeOfProduct = code;
                nameProduct = name;
                priseProduct = prise;
                this.category = category;
            }
            public void Print()
            {
                Console.WriteLine($"code: {codeOfProduct}, name: {nameProduct}, price: {priseProduct}, category: {category}");
            }
        }
        static void Main(string[] args)
        {
            string code = "0fx1456";
            string name = "Samsung Note 9";
            double price = 934.632;
            ArticleType category = ArticleType.Smartphone;
            Article a = new Article(code, name, price, category);
            a.Print();
        }
    }
}
