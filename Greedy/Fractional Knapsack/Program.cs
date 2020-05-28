using System;

namespace Fractional_Knapsack
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new Item[] {
                new Item{ Weight = 50, Value = 600 }, 
                new Item{ Weight = 20, Value = 500 }, 
                new Item{ Weight = 30, Value = 400}
            };
            var capacity = 70;

            int n = items.Length; 
            var result = new FractionalKnapsack().MaximumValue(items, n, capacity);
            Console.WriteLine($"Maximum Value = {result}");
        }
    }
}
