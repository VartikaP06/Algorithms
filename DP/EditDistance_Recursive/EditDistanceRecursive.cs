using System;

namespace EditDistance_Recursive
{
    public class EditDistanceRecursive
    {
        public int EditDistance(string s1, string s2, int m, int n)
        {
            if (s1 == s2)
            {
                return 0;
            }
            if (m == 0)
            {
                return n;
            }
            if (n == 0)
            {
                return m;
            }
            if (s1[m-1] == s2[n-1])
            {
                return EditDistance(s1, s2, m-1, n-1);
            }
            else {
                return 1 + Math.Min(EditDistance(s1, s2, m-1, n), 
                            Math.Min(EditDistance(s1, s2, m, n-1),
                            EditDistance(s1, s2, m-1, n-1)));
            }
        }
    }
}