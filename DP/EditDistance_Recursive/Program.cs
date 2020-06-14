using System;

namespace EditDistance_Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = "SUNDAY";
            var s2 = "SATURDAY";
            var ed = new EditDistanceRecursive().EditDistance(s1, s2, s1.Length, s2.Length);
            Console.WriteLine($"Edit Distance is : {ed}");
        }
    }
}
