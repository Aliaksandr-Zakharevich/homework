using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    class Control
    {
        public void Arriving (Product product, int arriving)
        {
            product.productQuantity += arriving;
            Console.WriteLine($"Quantity {product.name} chanched");
        }

        public void Sold(Product product, int sold)
        {
            if(product.productQuantity>sold)
            {
                product.productQuantity -= sold;
                Console.WriteLine($"Quantity {product.name} chanched");
            }
            else
            {
                Console.WriteLine("Invalid quantity");
            }
        }

        public void WrittenOff (Product product, int quantity)
        {
            if (product.productQuantity > quantity)
            {
                product.productQuantity -= quantity;
                Console.WriteLine($"Quantity {product.name} chanched");
            }
            else
            {
                Console.WriteLine("Invalid quantity");
            }
        }

        public void transferred(Product product, int quantity)
        {
            if (product.productQuantity > quantity)
            {
                product.productQuantity -= quantity;
                Console.WriteLine($"Quantity {product.name} chanched");
            }
            else
            {
                Console.WriteLine("Invalid quantity");
            }
        }
    }
}
