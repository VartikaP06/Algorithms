using System;

namespace MinimumCoins_Recursive
{
    public class MinimumCoins_Recursive
    {
        public int MinCoinsToValue(int[] coins, int val, int n)
        {
            if (val == 0)
            {
                return 0;
            }

            int res = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                if (coins[i] <= val)
                {
                    var sub_res = MinCoinsToValue(coins, val - coins[i], n);
                    if (sub_res != int.MaxValue)
                    {
                        res = Math.Min(res, sub_res + 1);
                    }
                }
            }

            return res;
        }
    }
}