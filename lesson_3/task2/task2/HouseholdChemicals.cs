using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    class HouseholdChemicals : Product
    {
        double weight;
        double coast;
        public HouseholdChemicals(string name, string codeProduct, int productQuantity, double weight, double coast): base(codeProduct,productQuantity, name)
        {
            this.weight = weight;
            this.coast = coast;
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Unit weight: {weight}\nUnit coast: {coast}");
        }
    }
}
