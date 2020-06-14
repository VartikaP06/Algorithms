using System;

namespace LIS
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new [] { 6, 3, 4, 2, 8, 10, 5, 1 };
            var lis = new LongestIncreasingSubsequence().Lis(arr, arr.Length);
            Console.WriteLine($"Longest Increasing Subsequence : {lis}");
        }
    }
}
