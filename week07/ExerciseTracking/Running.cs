public class Running : Activity
{
    private double _distance;

    public Running(double durationMin, string date, double distance) : base(durationMin, date)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetDuration()) * 60;
    }
}