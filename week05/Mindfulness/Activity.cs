using System.Threading.Channels;

public class Activity
{
    private string _name, _description;
    private int _duration = 0;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public int Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.Write($"""
        Welcome to the {_name} mindfulness activity.
        {_description}
        """);
        ChangeDuration();
        Console.Clear();
        ShowSpinner(3);
        Console.Write("Please prepare to begin... ");
        ShowCountDown(5);
        Console.Clear();
        Console.WriteLine("Beginning exercise\n");
    }

    public void ChangeDuration()
    {
        Console.WriteLine("\nHow long would you like this activity to last for? Please enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done completing the {_name} activity. This exercise lasted {_duration} seconds.");
        ShowSpinner(5);
        Console.WriteLine("Now exiting progam");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> bouncingAnimation = new List<string> { "O--", "-O-", "--O", "-O-" };

        for (int i = 0; i < seconds; i++)
        {
            Console.Write(bouncingAnimation[(i + 4) % 4]);
            Thread.Sleep(1000);
            Console.Write("\b\b\b");
        }
        Console.WriteLine("   ");
        Console.Write("\b\b\b");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}