using System;
using System.Data.SqlTypes;
using System.Security.Cryptography.X509Certificates;

public class Entry
{  
    

    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "How did I make the world a better place today?",
        "What was a realization I had today?",
        "If I were to remember only one thing from today, what would it be?",
        "What would I want to tell myself 5 years from now?",
    };
        

    public string _selectedPrompt;
    public string _userInput;
    public string _newEntry;

    public Entry()
    {
        Random rand = new Random();
        int randIndex = rand.Next(_prompts.Count);
        _selectedPrompt = _prompts[randIndex];

        DateTime theCurrentTime = DateTime.Now;
        string _dateText = theCurrentTime.ToShortDateString();

        Console.WriteLine(_dateText);
        Console.WriteLine(_selectedPrompt);
        
        _userInput = Console.ReadLine();
        _newEntry = ($"{_dateText}\n{_selectedPrompt}\n{_userInput}\n-");
        
    }
        
}