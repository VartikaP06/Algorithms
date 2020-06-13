using System;

namespace LongestCommonSubsequence
{
    public class MemoizationModel
    {
        public int[,] Memo { get; set; }

        public MemoizationModel(int m, int n)
        {
            InitializeMemo(m, n);
        }

        private void InitializeMemo(int m, int n)
        {
            Memo = new int[m+1, n+1];
            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    Memo[i, j] = -1;
                }
            }
        }
    }   
}