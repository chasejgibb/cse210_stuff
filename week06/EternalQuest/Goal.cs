
public abstract class Goal
{
    protected string _shortName, _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetGoalName()
    {
        return _shortName;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return $"Goal name: {_shortName} | Points to earn: {_points}\nYour goal is: {_description}";
    }

    public abstract string GetStringRepresentation();

    public abstract int LoadPoints();
}