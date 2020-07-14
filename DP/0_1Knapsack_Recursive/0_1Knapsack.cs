using System;

namespace _0_1Knapsack_Recursive
{
    public class _0_1Knapsack
    {
        public int Knapsack(int[] v, int[] wt, int W, int n)
        {
            if (n == 0 || W == 0)
            {
                return 0;
            }
            if (wt[n-1] > W)
            {
                return Knapsack(v, wt, W, n-1);
            }
            else {
                return Math.Max(Knapsack(v, wt, W, n-1), (v[n-1] + Knapsack(v, wt, W - wt[n-1], n-1)));
            }
        }
    }
}