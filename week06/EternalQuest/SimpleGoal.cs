public class SimpleGoal : Goal
{
    private bool _isComplete;

    // I understand in the design layout we are encouraged not to have a parameter for isComplete, however I thought it would be suitable
    // to have a default parameter so that I can use this parameter to load in goals that are already completed.

    public SimpleGoal(string name, string description, int points, bool isComplete = false) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (_isComplete == false)
        {
            _isComplete = true;
            return _points;
        }
        else
        {
            return 0;
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $$"""
        {
            "goaltype": "SimpleGoal",
            "name": "{{_shortName}}",
            "description": "{{_description}}",
            "points": "{{_points}}",
            "isComplete": "{{_isComplete}}"
        }
        """;
    }

    public override int LoadPoints()
    {
        if (_isComplete == true)
        {
            return _points;
        }
        else
        {
            return 0;
        }
    }
}