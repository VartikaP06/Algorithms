using System;

namespace LongestCommonSubsequence_Tabulation
{
    public class LongestCommonSubsequence
    {
        public int Lcs(string s1, string s2)
        {
            int m = s1.Length;
            int n = s2.Length;
            var dp = new int[m+1, n+1];

            for (int i = 0; i <= m; i++)
            {
                dp[i, 0] = 0;
            }
            for (int j = 0; j <= n; j++)
            {
                dp[0, j] = 0;
            }
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (s1[i - 1] == s2[j - 1])
                    {
                        dp[i, j] = 1 + dp[i - 1, j - 1];
                    }
                    else {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            return dp[m, n];
        }
    }
}