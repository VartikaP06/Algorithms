using System;

namespace LCS_Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = "ABCDGH";
            var s2 = "AEDFHR";

            var lcs = new LcsRecursive().Lcs(s1, s2, s1.Length, s2.Length);
            Console.WriteLine($"LCS : {lcs}");
        }
    }
}
