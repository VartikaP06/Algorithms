namespace LargestNumber
{
    public class FindLargestNumber
    {
        public string LargestNumber(int n, int sum)
        {
            var password = string.Empty;
            int currSum = sum;
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 9; j >= 0; j--)
                {
                    if (j <= currSum)
                    {
                        password += j;
                        currSum -= j;
                        break;
                    }
                    else if (currSum == 0)
                    {
                        password += 0;
                        break;
                    }
                }
            }
            
            if (currSum > 0)
            {
                return "-1";
            }
            else
            {
                return password;
            }
        }
    }
}