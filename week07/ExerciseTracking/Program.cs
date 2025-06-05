using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> records = new()
        {
            new Running(15, "27 April 2025", 5.0),
            new Biking(45, "01 December 1998", 23.2),
            new Swimming(30, "18 June 2024", 8)
        };
        
        foreach (Activity activity in records)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}