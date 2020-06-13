using System;

namespace LongestCommonSubsequence
{
    public class LongestCommonSubsequence
    {
        public string String1 { get; set; }
        public string String2 { get; set; }

        public MemoizationModel MemoizationModel { get; set; }

        public int[, ] Memo { get; set; }

        public LongestCommonSubsequence(string s1, string s2)
        {
            String1 = s1;
            String2 = s2;
            MemoizationModel = new MemoizationModel(s1.Length, s2.Length);
            Memo = MemoizationModel.Memo;
        }

        public int Lcs(int m, int n)
        {
            if (Memo[m, n] == -1)
            {
                var res = 0;
                if (m == 0 || n == 0)
                {
                    res = 0;
                }
                else if (m == n && String1 == String2)
                {
                    res = m;
                }
                else {
                    if (String1[m-1] == String2[n-1])
                    {
                        res = 1 + Lcs(m-1, n-1);
                    }
                    else {
                        res = Math.Max(Lcs(m-1, n), 
                                        Lcs(m, n-1));
                    }
                }
                Memo[m, n] = res;
            }

            return Memo[m, n];
        }
    }
}