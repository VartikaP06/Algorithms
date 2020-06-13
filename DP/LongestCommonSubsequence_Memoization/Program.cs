using System;

namespace LongestCommonSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = "XYZ";
            var s2 = "XYZ";
            var m = s1.Length;
            var n = s2.Length;

            var longestCommonSubsequence = new LongestCommonSubsequence(s1, s2);
            int lcs = longestCommonSubsequence.Lcs(m, n);
            Console.WriteLine($"LCS is : {lcs}");
        }
    }
}
