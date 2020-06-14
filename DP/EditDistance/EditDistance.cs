using System;

namespace EditDistance
{
    public class EditDistance
    {
        public int GetEditDistance(string s1, string s2, int m, int n)
        {
            var dp = new int[m+1, n+1];

            for (int j = 0; j <= n; j++)
            {
                dp[0, j] = j;
            }
            for (int i = 1; i <= m; i++)
            {
                dp[i, 0] = i;
            }
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (s1[i - 1] == s2[j - 1])
                    {
                        dp[i, j] = dp[i-1, j-1];
                    }
                    else {
                        dp[i, j] = 1 + Math.Min(dp[i, j-1], Math.Min(dp[i-1, j], dp[i-1, j-1]));
                    }
                }
            }

            return dp[m, n];
        }
    }
}