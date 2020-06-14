using System;

namespace LCS_Recursive
{
    public class LcsRecursive
    {
        public int Lcs(string s1, string s2, int m , int n)
        {
            if (m == 0 || n == 0)
            {
                return 0;
            }
            if (s1 == s2)
            {
                return s1.Length;
            }
            if (s1[m-1] == s2[n-1])
            {
                return 1 + Lcs(s1, s2, m-1, n-1);
            }
            else {
                return Math.Max(Lcs(s1, s2, m-1, n), Lcs(s1, s2, m, n-1));
            }
        }
    }
}