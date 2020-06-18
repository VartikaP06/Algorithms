using System;

namespace MinimumCoins_Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new [] { 25, 10, 5 };
            var val = 30;

            var minCoins = new MinimumCoins_Recursive().MinCoinsToValue(arr, val, arr.Length);
            Console.WriteLine($"Minimum Coins to make value {val} : {minCoins}");
        }
    }
}
