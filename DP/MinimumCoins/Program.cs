using System;

namespace MinimumCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            var coins = new [] { 25, 10, 5 };
            var val = 40;

            var minCoins = new MinimumCoins().MinCoins(coins, coins.Length, val);
            if (minCoins == -1)
            {
                Console.WriteLine($"Not possible to get {val} as a combination of given coins");
            }
            else {
                Console.WriteLine($"Minimum Coins to make value {val} : {minCoins}");
            }
        }
    }
}
