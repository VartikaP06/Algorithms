using System;

public class ActivitySelection
{
    public void SelectActivity(Activity[] activities, int n)
    {
        Array.Sort(activities, new TimeComparer());
    
        int i = 0;
        Console.WriteLine(activities[i].StartTime + " " + activities[i].FinishTime);

        for (int j = 1; j < n; j++)
        {
            if (activities[j].StartTime >= activities[i].FinishTime)
            {
                Console.WriteLine(activities[j].StartTime + " " + activities[j].FinishTime);
                i = j;
            }
        }
    }
}