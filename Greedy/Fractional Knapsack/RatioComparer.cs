using System.Collections.Generic;

public class RatioComparer : IComparer<Item>
{
    public int Compare(Item x, Item y)
    {
        return x.Ratio < y.Ratio ? 1 : x.Ratio == y.Ratio ? 0 : -1;
    }
}