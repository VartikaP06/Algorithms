using System;

namespace _0_1Knapsack_Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new [] { 10, 40, 30, 50 };
            var weights = new [] { 5, 4, 6, 3 };
            var capacity = 10;

            var maxValue = new _0_1Knapsack().Knapsack(values, weights, capacity, values.Length);
            Console.WriteLine($"Maximum Possible Value of Knapsack is : {maxValue}");
        }
    }
}
