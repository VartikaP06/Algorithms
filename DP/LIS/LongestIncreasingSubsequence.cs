using System;

namespace LIS
{
    public class LongestIncreasingSubsequence
    {
        public int Lis(int[] arr, int n)
        {
            if (n == 0) return -1;
            var lis = new int[n];
            for (int i = 0; i < n; i++)
            {
                lis[i] = 1;
                for (int j = i-1; j >= 0; j--)
                {
                    if (arr[i] > arr[j])
                    {
                        lis[i] = Math.Max(lis[i], lis[j] + 1);
                    }
                }
            }

            var max = lis[0];
            for (int i = 1; i < n; i++)
            {
                max = Math.Max(max, lis[i]);
            }

            return max;
        }
    }
}