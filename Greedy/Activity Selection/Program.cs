namespace Activity_Selection
{
    class Program
    {
        static void Main(string[] args)
        {
            var activities = new Activity[] {
                new Activity{ StartTime = 5, FinishTime = 9}, 
                new Activity{ StartTime = 1, FinishTime = 2}, 
                new Activity{ StartTime = 3, FinishTime = 4}, 
                new Activity{ StartTime = 0, FinishTime = 6}, 
                new Activity{ StartTime = 5, FinishTime = 7}, 
                new Activity{ StartTime = 8, FinishTime = 9}
            }; 

            int n = activities.Length; 
            new ActivitySelection().SelectActivity(activities, n);  
        }
    }
}
