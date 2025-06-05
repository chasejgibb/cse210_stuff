using System.Text.Json;

// make the loadfile method load in points for completed goals and also add the goals into their 
// respective lists like if they're completed or not

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private List<Goal> _completedGoals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        Console.Clear();
        bool go = true;
        while (go)
        {

            Console.WriteLine("""
            Welcome to your personalized goal tracker! Please select a following option by entering a number
            1. View score
            2. View current goals
            3. View completed goals
            4. Add new goal
            5. Complete a goal
            6. Save file
            7. Load file
            8. Help
            9. Clear your current goals 
            10. Quit
            """);
            string menuChoice = Console.ReadLine();
            switch (menuChoice)
            {
                case "1":
                    Thread.Sleep(2);
                    DisplayPlayerInfo();

                    break;
                case "2":
                    Thread.Sleep(2);
                    ListGoalNames(_goals);

                    break;
                case "3":
                    Thread.Sleep(2);
                    ListGoalNames(_completedGoals);

                    break;
                case "4":
                    Thread.Sleep(2);
                    CreateGoal();

                    break;
                case "5":
                    Thread.Sleep(2);
                    RecordEvent();

                    break;
                case "6":
                    Thread.Sleep(2);
                    SaveGoals();

                    break;
                case "7":
                    Thread.Sleep(2);
                    LoadGoals();

                    break;
                case "8":
                    Thread.Sleep(2);
                    Help();
                    break;
                case "9":
                    Thread.Sleep(2);
                    ClearGoals();
                    break;
                case "10":
                    go = false;
                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;
            }

        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nCongragulations, you have a score of {_score}!");
    }

    public void ListGoalNames(List<Goal> goalsList)
    {
        int counter = 1;
        Console.WriteLine();
        foreach (Goal goal in goalsList)
        {
            Console.WriteLine($"Goal #{counter}: {goal.GetGoalName()}\n{ListGoalDetails(goal)}");
            Console.WriteLine();
            counter++;
        }
    }

    public string ListGoalDetails(Goal goal)
    {
        return goal.GetDetailsString();
    }

    public void Help()
    {
        Console.Write("""
        ------
        We'd love to recommend you some goals! Select which category you'd like to view
        1. Simple Goals
        2. Eternal Goals
        3. Checklist Goals
        Enter a number: 
        """);
        string helpChoice = Console.ReadLine();
        switch (helpChoice)
        {
            case "1":
                Thread.Sleep(2);
                SimpleHelp();
                break;
            case "2":
                Thread.Sleep(2);
                EternalHelp();
                break;
            case "3":
                Thread.Sleep(2);
                ChecklistHelp();
                break;
            default:
                Console.Write("Try again: ");
                break;
        }
    }

    public void SimpleHelp()
    {
        Console.Write("""
        Here are some simple and easy goals to help start you on your goal journey!
        1. Say a meaningful prayer
        2. Make your bed
        3. Dump your girlfriend that you know it won't work out with
        4. Stop smoking
        5. None of these
        Enter a number: 
        """);
        string simpleHelpChoice = Console.ReadLine();
        switch (simpleHelpChoice)
        {
            case "1":
                Thread.Sleep(2);
                _goals.Add(new SimpleGoal("Pray", "Take time and offer a thoughtful prayer to your Heavenly Father", 40));
                break;
            case "2":
                Thread.Sleep(2);
                _goals.Add(new SimpleGoal("Make your bed", "...Make your bed... duh", 20));
                break;
            case "3":
                Thread.Sleep(2);
                _goals.Add(new SimpleGoal("Dump her", "Be honest... You're not even into cougars.", 50));
                break;
            case "4":
                Thread.Sleep(2);
                _goals.Add(new SimpleGoal("Don't smoke", "Unless you wanna sound like the daleks from Dr. Who", 100));
                break;
            case "5":
                Thread.Sleep(2);
                break;
            default:
                Console.Write("Try again: ");
                break;
        }
    }
    public void EternalHelp()
    {
        Console.Write("""
        Here are some important goals that you can do for the rest of your life
        1. Read the scriptures daily
        2. Listen to a general conference talk
        3. Go to the temple
        4. None of these
        Enter a number: 
        """);
        string eternalHelpChoice = Console.ReadLine();
        switch (eternalHelpChoice)
        {
            case "1":
                Thread.Sleep(2);
                _goals.Add(new EternalGoal("Scripture Study", "Read a chapter from the scriptures", 50));
                break;
            case "2":
                Thread.Sleep(2);
                _goals.Add(new EternalGoal("Conference Talk", "Listen to a talk from the most recent general conference", 50));
                break;
            case "3":
                Thread.Sleep(2);
                _goals.Add(new SimpleGoal("Temple", "Spend some time at the temple performing ordinances for our deceased ancestors", 60));
                break;
            case "4":
                Thread.Sleep(2);
                break;
            default:
                Console.Write("Try again: ");
                break;
        }
    }

    public void ChecklistHelp()
    {
        Console.Write("""
        Here are some useful checklist goals that you'll get a bonus from!
        1. Go to the gym 6 times
        2. Do your homework 5 days this week
        3. Read a good book
        4. Clean your dishes
        5. None of these
        Enter a number: 
        """);
        string checklistHelpChoice = Console.ReadLine();
        switch (checklistHelpChoice)
        {
            case "1":
                Thread.Sleep(2);
                _goals.Add(new ChecklistGoal("Gym", "Have a good workout at the gym 6 times", 20, 0, 6, 100));
                break;
            case "2":
                Thread.Sleep(2);
                _goals.Add(new ChecklistGoal("Homework", "Do homework once a day from monday - friday", 20, 0, 5, 100));
                break;
            case "3":
                Thread.Sleep(2);
                _goals.Add(new ChecklistGoal("Read a book", "Sit down and read through some chapters of your favorite book", 20, 0, 3, 100));
                break;
            case "4":
                Thread.Sleep(2);
                _goals.Add(new ChecklistGoal("Cleaning", "Put on those dish gloves and make your roommates happy by doing your dishes!", 20, 0, 10, 100));
                break;
            case "5":
                Thread.Sleep(2);
                break;
            default:
                Console.Write("Try again: ");
                break;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Lets make a new goal! What type of goal do you want?\nA simple one time goal, an eternal repeating goal, or a longer checklist goal?\nEnter 1 for simple, 2 for eternal, and 3 for checklist.");
        string goalType = Console.ReadLine();
        Console.WriteLine("What would you like to name your goal?");
        string goalName = Console.ReadLine();
        Console.WriteLine("Goal description: ");
        string goalDescription = Console.ReadLine();
        Console.WriteLine("How many points will be earned each time this goal is completed?");
        int goalPoints = Int32.Parse(Console.ReadLine());

        if (goalType == "1")
        {
            _goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints));
            Console.WriteLine("Goal created successfully :)");
        }
        else if (goalType == "2")
        {
            _goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
            Console.WriteLine("Goal created successfully :)");
        }
        else if (goalType == "3")
        {
            Console.WriteLine("How many times do you want to complete this goal before gaining a bonus?");
            int goalTarget = Int32.Parse(Console.ReadLine());
            Console.WriteLine("And what would you like that bonus to be?");
            int goalBonus = Int32.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, 0, goalTarget, goalBonus));
            Console.WriteLine("Goal created successfully :)");
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("Add some goals first!");
        }
        else
        {
            Console.WriteLine("Which goal have you completed? :D Enter a number corresponding to the goal.");
            ListGoalNames(_goals);
            int choice = Int32.Parse(Console.ReadLine());
            _score = _score + _goals[choice - 1].RecordEvent();
            if (_goals[choice - 1].IsComplete())
            {
                _completedGoals.Add(_goals[choice - 1]);
                _goals.RemoveAt(choice - 1);
            } 
        }
    }

    public void ClearGoals()
    {
        _goals.Clear();
    }

    public void SaveGoals()
    {
        List<string> saveString = new List<string>();
        saveString.Add("[");
        if (_goals.Count != 0)
        {
            foreach (Goal goal in _goals)
            {
                saveString.Add(goal.GetStringRepresentation());
                saveString.Add(",");
            }
        }
        if (_completedGoals.Count != 0)
        {
            foreach (Goal goal in _completedGoals)
            {
                saveString.Add(goal.GetStringRepresentation());
                saveString.Add(",");
            }
        }
        if (saveString.Count > 1)
        {
            saveString.RemoveAt(saveString.Count - 1);
        }
        saveString.Add("]");

        Console.Write("File is ready to be saved. Please enter the file name you'd like to save to (ending with .json): ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (string line in saveString)
            {
                outputFile.WriteLine(line);
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("Please enter the file name you'd like to load (ending with .json): ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            var json = File.ReadAllText(fileName);
            var document = JsonDocument.Parse(json);

            foreach (var element in document.RootElement.EnumerateArray())
            {
                string goalType = element.GetProperty("goaltype").GetString();
                string name = element.GetProperty("name").GetString();
                string description = element.GetProperty("description").GetString();
                int points = Int32.Parse(element.GetProperty("points").GetString());

                if (goalType == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(element.GetProperty("isComplete").GetString());
                    if (isComplete)
                    {
                        _completedGoals.Add(new SimpleGoal(name, description, points, isComplete));
                    }
                    else
                    {
                        _goals.Add(new SimpleGoal(name, description, points, isComplete));
                    }
                }
                else if (goalType == "EternalGoal")
                {
                    int timesCompleted = Int32.Parse(element.GetProperty("timesCompleted").GetString());
                    _goals.Add(new EternalGoal(name, description, points, timesCompleted));
                }
                else if (goalType == "ChecklistGoal")
                {
                    int timesCompleted = Int32.Parse(element.GetProperty("timesCompleted").GetString());
                    int target = Int32.Parse(element.GetProperty("target").GetString());
                    int bonus = Int32.Parse(element.GetProperty("bonus").GetString());
                    if (timesCompleted >= target)
                    {
                        _completedGoals.Add(new ChecklistGoal(name, description, points, timesCompleted, target, bonus));
                    }
                    else if (timesCompleted < target)
                    {
                        _goals.Add(new ChecklistGoal(name, description, points, timesCompleted, target, bonus));
                    }
                }
            }
            foreach (Goal goal in _completedGoals)
            {
                _score = _score + goal.LoadPoints();
            }
            foreach (Goal goal in _goals)
            {
                _score = _score + goal.LoadPoints();
            }
        }
        else
        {
            Console.WriteLine("Unable to locate file");
        }
    }
}