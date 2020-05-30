using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOfDigits = 5;
            var sum = 12;

            var password = new FindLargestNumber().LargestNumber(numOfDigits, sum);
            System.Console.WriteLine($"Password is = {password}");
        }
    }
}
