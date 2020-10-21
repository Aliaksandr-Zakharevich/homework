using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    public abstract class Product
    {
        string codeProduct;
        public string name { get; set; }
        public int productQuantity { get; set; }
        
        public Product(string codeProduct, int productQuantity, string name)
        {
            this.name = name;
            this.codeProduct = codeProduct;
            this.productQuantity = productQuantity;
           
        }
        public void Print()
        {
            Console.WriteLine($"Code of product: {codeProduct}\nQuantity: {productQuantity}\nName: {name}");
        }
    }
}
