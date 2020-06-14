using System;

namespace LIS_Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new [] { 19, 10, 6, 5, 8, 11, 2, 20, 3, 21 };
            var lcs = new LongestIncreasingSubsequence().Lis(arr, arr.Length);
            Console.WriteLine($"Longest common Subsequence : {lcs}");
        }
    }
}
