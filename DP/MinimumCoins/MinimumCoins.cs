using System;

namespace MinimumCoins
{
    public class MinimumCoins
    {
        public int MinCoins(int[] coins, int n, int val)
        {
            var dp = new int[val+1];

            for (int i = 1; i <= val; i++)
            {
                dp[i] = int.MaxValue;
                for (int j = 0; j < n; j++)
                {
                    if (coins[j] <= i)
                    {
                        var sub_res = dp[i - coins[j]];
                        if (sub_res != int.MaxValue)
                        {
                            dp[i] = Math.Min(dp[i], sub_res + 1);
                        }
                    }
                }
            }

            return dp[val] != int.MaxValue ? dp[val] : -1;
        }
    }
}