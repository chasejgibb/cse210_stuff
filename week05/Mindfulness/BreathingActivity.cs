public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        base.DisplayStartingMessage();

        base.Duration = (int)Math.Round(base.Duration / 10.0) * 10;

        for (int i = base.Duration; i > 0; i -= 10)
        {
            Console.Write("Breathe in through your nose... ");
            base.ShowCountDown(4);
            Thread.Sleep(4);
            Console.WriteLine("\n");

            Console.Write("Now breathe out your mouth... ");
            base.ShowCountDown(6);
            Thread.Sleep(6);
            Console.WriteLine("\n");

        }
        
        // Source for Math.Round : https://learn.microsoft.com/en-us/dotnet/api/system.math.round?view=net-9.0
        base.DisplayEndingMessage();
    }
}


