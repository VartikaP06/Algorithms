using System;

public class FractionalKnapsack
{
    public double MaximumValue(Item[] items, int n, int capacity)
    {
        // Find Value to weight to weight ratio of every item.
        for (int i = 0; i < n; i++)
        {
            items[i].Ratio = items[i].Value / items[i].Weight;
        }

        // Sort the items in descending order of value to wight ratio
        Array.Sort(items, new RatioComparer());

        var currCapacity = capacity;
        var maxValue = 0.0;

        for (int i = 0; i < n; i++)
        {
            // If weight of item is less than current capacity
            // -> include it completely
            if (items[i].Weight < currCapacity)
            {
                maxValue += items[i].Value;
                currCapacity -= items[i].Weight;
            }
            else // Include it partially and break, since Knapsack capacity is full after this.
            {
                maxValue += items[i].Ratio * currCapacity;
                break;
            }
        }

        return maxValue;
    }
}