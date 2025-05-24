using System;

// For creativity I added a separate activity that asks why questions and helps you get down to the root of your feelings/problems

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("""
        Please select one of the following options:
            1. Breathing Activity
            2. Reflection Activity
            3. Listing Activity
            4. Why Activity
            5. Exit Program
        Enter your choice: 
        """);

        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            BreathingActivity runningActivity = new BreathingActivity("Breathing", "This exercise will to help you relax as you control your breathing. Clear your mind and focus on your breathing.");
            runningActivity.Run();
            // As a side note, I decided that the breathing activity will not last only as long as the user asks
            // However this is only because each breathing sequence last a certain duration of time. It would be silly
            // to have someone breath in for x seconds and then as they are breathing out, suddenly kill the program mid-breath
            // just to comply with a duration request. The class will instead round the requested time to the nearest 10 seconds and run for that long 
        }
        else if (choice == 2)
        {
            ReflectionActivity runningActivity = new ReflectionActivity("Reflection", "This exercise will guide you as you choose an important experience and answer questions relating to it.");
            runningActivity.Run();
        }
        else if (choice == 3)
        {
            ListingActivity runningActivity = new ListingActivity("Listing", "This exercise will help you list positive things related to certain areas in your life.");
            runningActivity.Run();
        }
        else if (choice == 4)
        {
            WhyActivity runningActivity = new WhyActivity("Why", """
            When we feel stressed, sad, or anxious, it's healthy to reasses our values and ask ourselves why things are making us feel certain ways.
            This exercise will help you think about your issues and values.
            """);
            runningActivity.Run();
        }
        else if (choice == 5)
        {
            return;
        }



    }
}