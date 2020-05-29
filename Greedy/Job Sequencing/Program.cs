using System;

namespace Job_Sequencing
{
    class Program
    {
        static void Main(string[] args)
        {
            var jobs = new [] 
            { 
                new Job{ Deadline = 2, Profit = 100 },
                new Job{ Deadline = 1, Profit = 50 },
                new Job{ Deadline = 2, Profit = 100 },
                new Job{ Deadline = 1, Profit = 20 },
                new Job{ Deadline = 3, Profit = 30 }
            };
            
            var maxProfit = new JobSequencing().MaxProfit(jobs, jobs.Length);
            Console.WriteLine("=================================================================");
            Console.WriteLine($"Max Profit Possible = {maxProfit}");
        }
    }
}
