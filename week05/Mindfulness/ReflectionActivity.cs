public class ReflectionActivity : Activity
{
    private Random _rand = new Random();

    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
       "Why was this experience meaningful to you?",
       "Have you ever done anything like this before?",
       "How did you get started?",
       "How did you feel when it was complete?",
       "What made this time different than other times when you were not as successful?",
       "What is your favorite thing about this experience?",
       "What could you learn from this experience that applies to other situations?",
       "What did you learn about yourself through this experience?",
       "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        base.DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:\n");
        DisplayPrompt();
        Console.WriteLine("\nWhen you are ready, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("\nThink about the following questions as they relate to your experience:\n");
        Console.Write("Let's begin in... ");
        base.ShowCountDown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(base.Duration);

        while (DateTime.Now < futureTime)
        {
            DisplayQuestion();
            base.ShowSpinner(5);
        }

            base.DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        int randomNumber = _rand.Next(0, _prompts.Count);
        return _prompts[randomNumber];
    }

    public string GetRandomQuestion()
    {
        int randomNumber = _rand.Next(0, _questions.Count);
        return _questions[randomNumber];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestion()
    {
        Console.WriteLine($"{GetRandomQuestion()}\n");
    }



}