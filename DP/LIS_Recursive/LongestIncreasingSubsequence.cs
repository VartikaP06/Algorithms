using System;

namespace LIS_Recursive
{
    public class LongestIncreasingSubsequence
    {
        public int Lis(int[] arr, int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            if (arr[n-1] > arr[n-2])
            {
                return 1 + Lis(arr, n-1);
            }
            else
            {
                return Lis(arr, n-1);
            }
        }
    }
}