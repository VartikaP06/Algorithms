using System;

namespace LongestCommonSubsequence_Tabulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = "AXYZ";
            var s2 = " BAZ";

            var lcs = new LongestCommonSubsequence().Lcs(s1, s2);
            Console.WriteLine($"LCS is : {lcs}");
        }
    }
}
