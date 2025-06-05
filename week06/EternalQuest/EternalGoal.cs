public class EternalGoal : Goal
{
    private int _timesCompleted;
    public EternalGoal(string name, string description, int points, int timesCompleted = 0) : base(name, description, points)
    {
        _timesCompleted = timesCompleted;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $$"""
        {
            "goaltype": "EternalGoal",
            "name": "{{_shortName}}",
            "description": "{{_description}}",
            "points": "{{_points}}",
            "timesCompleted": "{{_timesCompleted}}"
        }
        """;
    }

        public override int LoadPoints()
    {
        return _points * _timesCompleted;
    }
}