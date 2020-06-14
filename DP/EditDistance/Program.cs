using System;

namespace EditDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = "SUNDAY";
            var s2 = "SATURDAY";
            
            var editDistance = new EditDistance().GetEditDistance(s1, s2, s1.Length, s2.Length);
            Console.WriteLine($"Edit Distance : {editDistance}");
        }
    }
}
