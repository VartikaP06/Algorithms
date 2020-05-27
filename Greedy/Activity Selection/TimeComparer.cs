using System.Collections.Generic;

public class TimeComparer : IComparer<Activity>
{
    public int Compare(Activity x, Activity y)
    {
        return x.FinishTime > y.FinishTime ? 1 : x.FinishTime == y.FinishTime ? 0 : -1;
    }
}