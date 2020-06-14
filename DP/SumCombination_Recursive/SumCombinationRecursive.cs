namespace SumCombination_Recursive
{
    public class SumCombinationRecursive
    {
        public int GetCount(int[] coins, int n, int sum)
        {
            if (sum == 0)
            {
                return 1;
            }
            if (n == 0)
            {
                return 0;
            }
            var res = GetCount(coins, n-1, sum);
            if (coins[n - 1] <= sum)
            {
                res += GetCount(coins, n, sum - coins[n - 1]);
            }
            return res;
        }
    }
}