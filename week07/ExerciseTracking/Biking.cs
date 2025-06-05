public class Biking : Activity
{
    private double _speed;

    public Biking(double durationMin, string date, double speed) : base(durationMin, date)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (GetDuration() / 60);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}