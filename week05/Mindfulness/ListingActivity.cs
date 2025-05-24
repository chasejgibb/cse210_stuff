
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private Random _rand = new Random();

    public ListingActivity(string name, string description, int count = 0) : base(name, description)
    {
        _count = count;
    }

    public void Run()
    {
        base.DisplayStartingMessage();

        GetRandomPrompt();
        GetListFromUser();
        Console.WriteLine($"You listed {_count}\n");

        base.DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        int randomNumber = _rand.Next(0, _prompts.Count);
        Console.WriteLine($"\n---{_prompts[randomNumber]}---\n");
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();

        Console.Write("You may begin in... ");
        base.ShowCountDown(5);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(base.Duration);

        while (DateTime.Now < futureTime)
        {
            userList.Add(Console.ReadLine());
            // I couldn't figure out how to make a non-blocking readline without more advanced code that I didn't understand
            // so I didn't want to try and use it
        }

        _count = userList.Count;
        return userList;
    }
}
