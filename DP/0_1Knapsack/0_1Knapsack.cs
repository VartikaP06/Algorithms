using System;

namespace _0_1Knapsack
{
    public class _0_1Knapsack
    {
        public int Knapsack(int[] v, int[] wt, int W, int n)
        {
            var dp = new int[n+1, W+1];

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= W; j++)
                {
                    if (wt[i-1] > j)
                    {
                        dp[i, j] = dp[i-1, j];
                    }
                    else {
                        dp[i, j] = Math.Max(dp[i-1, j], v[i-1] + dp[i-1, (j - wt[i-1])]);
                    }
                }
            }

            return dp[n, W];
        }
    }
}