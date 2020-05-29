using System;

namespace Job_Sequencing
{
    public class JobSequencing
    {
        public int MaxProfit(Job[] jobs, int n)
        {
            //Sort the jobs in decreasing order of profit
            Array.Sort(jobs, new ProfitComparer());

            var profitableJobs = new Job[n];
            profitableJobs[jobs[0].Deadline - 1] = jobs[0]; //Assign the latest slot to the first job in the sorted job list
            
            //Repeat for the remaining n-1 jobs
            //If the position (Deadline - 1) for the job and all positions before it, are already occupied --> Ignore this job
            //Else, put this job at the latest available slot, at or before its suitable position.
            for (int i = 1; i < n; i++)
            {
                var pos = jobs[i].Deadline - 1;
                for (int j = pos; j >= 0; j--)
                {
                    //If a position is found, add the job, and break out of the loop since job is already added to its suitable latest position
                    if (profitableJobs[j] == null)
                    {
                        profitableJobs[j] = jobs[i];
                        break;
                    }
                }
            }

            Console.WriteLine("Selected Jobs are :");
            Console.WriteLine("=================================================================");

            for (int i = 0; i < n; i++)
            {
                if (profitableJobs[i] != null)
                {
                    Console.WriteLine($"Deadline : {profitableJobs[i].Deadline} and Profit : {profitableJobs[i].Profit}");
                }
            }

            var maxProfit = 0;
            for (int i = 0; i < profitableJobs.Length; i++)
            {
                if (profitableJobs[i] != null)
                {
                    maxProfit += profitableJobs[i].Profit;
                }
            }

            return maxProfit;
        }
    }
}