public class Swimming : Activity
{
    private double _numLaps;

    public Swimming(double durationMin, string date, double numLaps) : base(durationMin, date)
    {
        _numLaps = numLaps;
    }

    public override double GetDistance()
    {
        return (_numLaps * 50) / 1000;
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