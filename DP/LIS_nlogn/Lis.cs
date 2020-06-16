using System.Collections.Generic;

namespace LIS_nlogn
{
    public class LIS_nlogn
    {
        public int Lis(int[] arr, int n)
        {
            var dp = new List<int>();
            dp.Add(arr[0]);

            for (int i = 1; i < n; i++)
            {
                var len = dp.Count;
                if (arr[i] >= dp[len-1])
                {
                    dp.Add(arr[i]);
                }
                else {
                    var cIdx = FindCeilIndex(dp, 0, len-1, arr[i]);
                    dp[cIdx] = arr[i];
                }
            }

            return dp.Count;
        }

        private int FindCeilIndex(List<int> tail, int l, int r, int x)
        {
            while (r > l)
            {
                var m = l + (r - l) / 2;
                if (tail[m] >= x)
                {
                    r = m;
                }
                else {
                    l = m + 1;
                }
            }
            return r;
        }
    }
}