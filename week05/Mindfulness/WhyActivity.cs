public class WhyActivity : Activity
{
    private List<string> _responses = new List<string>();
    public WhyActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        base.DisplayStartingMessage();
        Console.WriteLine("This will take only as long as it takes for you to answer the prompts.");
        GetResponseList();
        DisplayResponses();

        base.DisplayEndingMessage();
    }

    public void GetResponseList()
    {
        Console.WriteLine("What is a negative emotion you are feeling? ");
        base.ShowSpinner(5);
        _responses.Add(Console.ReadLine());

        Console.WriteLine("What event or experience seems to be causing that emotion?");
        base.ShowSpinner(5);
        _responses.Add(Console.ReadLine());

        Console.WriteLine("Why does that seem make you feel this way?");
        base.ShowSpinner(5);
        _responses.Add(Console.ReadLine());

        Console.WriteLine("Why does that seem true?");
        base.ShowSpinner(5);
        _responses.Add(Console.ReadLine());

        Console.WriteLine("Does this judgement seem fair? Are there other factors that you havent considered? Take time to reconsider ");
        base.ShowSpinner(5);
    }

    public void DisplayResponses()
    {
        Console.WriteLine($"""
        Your_responses were:
        Negative emotion: {_responses[0]}
        Cause of emotion: {_responses[1]}
        Makes you feel that way because: {_responses[2]}
        Seems true because: {_responses[3]}
        """);
    }

    // Ask about a negative feeling 
    // Ask about the source of that feeling
    // Ask why that source is causing that feeling
    // Ask why that seems true
    // Invite to reasess values and reconsider if your values are what you want them to be

}