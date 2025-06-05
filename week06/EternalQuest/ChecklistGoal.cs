public class ChecklistGoal : Goal
{
    private int _timesCompleted, _target, _bonus;

    public ChecklistGoal(string name, string description, int points, int amountCompleted, int target, int bonus) : base(name, description, points)
    {
        _timesCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        if (_timesCompleted == _target)
        {
            return _points + _bonus;
        }
        else if (_timesCompleted < _target)
        {
            return _points;
        }
        else
        {
            return 0;
        }
    }

    public override bool IsComplete()
    {
        if (_timesCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        return $"Completed {_timesCompleted}/{_target} times";
    }

    public override string GetStringRepresentation()
    {
        return $$"""
        {
            "goaltype": "ChecklistGoal",
            "name": "{{_shortName}}",
            "description": "{{_description}}",
            "points": "{{_points}}",
            "timesCompleted": "{{_timesCompleted}}",
            "target":"{{_target}}",
            "bonus":"{{_bonus}}"
        }
        """;
    }

        public override int LoadPoints()
    {
        if (_timesCompleted >= _target)
        {
            return (_points * _timesCompleted) + _bonus ;
        }
        else
        {
            return _points * _timesCompleted;
        }
    }
}