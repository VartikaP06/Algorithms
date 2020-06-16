using System;

namespace MaxCuts
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 5;
            var a = 3;
            var b = 2;
            var c = 1;
            var maxCuts = new MaximumCuts().MaxCuts(n, a, b, c);
            if ( maxCuts == -1)
            {
                Console.WriteLine($"No cuts of length {a} or {b} or {c} possible in a rope of length {n}");
            }
            else {
                Console.WriteLine($"Maximum cuts of length either {a} or {b} or {c}, possible in a rope of length {n} : {maxCuts}");
            }
        }
    }
}
