using System;

namespace task2
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            HouseholdChemicals chemicals = new HouseholdChemicals("Soap-powder", "0fx234", 12, 2.4, 17.42);
            Food food = new Food("0fx4241", 25, "Apple", 0.32, 0.78);
            chemicals.Print();
            Console.WriteLine();
            food.Print();
            Control control = new Control();
            control.Arriving(chemicals, 5);
            control.Sold(food, 10);
            control.WrittenOff(food, 10);
            control.transferred(food, 10);
            Console.WriteLine();
            chemicals.Print();
            Console.WriteLine();
            food.Print();
        }
    }
}
