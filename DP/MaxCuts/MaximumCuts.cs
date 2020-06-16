using System;

namespace MaxCuts
{
    public class MaximumCuts
    {
        public int MaxCuts(int n, int a, int b, int c)
        {
            var dp = new int[n+1];
            dp[0] = 0;
            
            for (int i = 1; i <= n; i++)
            {
                dp[i] = -1;
                if (i - a >= 0)
                {
                    dp[i] = Math.Max(dp[i], dp[i-a]);
                }
                if (i - b >= 0)
                {
                    dp[i] = Math.Max(dp[i], dp[i-b]);
                }
                if (i - c >= 0)
                {
                    dp[i] = Math.Max(dp[i], dp[i-c]);
                }

                if (dp[i] != -1)
                {
                    dp[i]++;
                }
            }

            return dp[n];
        }
    }
}