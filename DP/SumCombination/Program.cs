using System;

namespace SumCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            var coins = new [] { 2, 5, 3, 6 };
            int sum = 10;
            var combinationCount = new SumCombination().GetCount(coins, coins.Length, sum);
            Console.WriteLine($"Count of combinations for a given sum : {combinationCount}");
        }
    }
}
