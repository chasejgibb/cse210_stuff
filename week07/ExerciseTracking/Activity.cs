public abstract class Activity
{
    private double _durationMin;
    private string _date;

    public Activity(double durationMin, string date)
    {
        _durationMin = durationMin;
        _date = date;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public double GetDuration()
    {
        return _durationMin;
    }

    public string GetDate()
    {
        return _date;
    }

    public virtual string GetSummary()
    {
        return $"{GetDate()} Running ({GetDuration()} min) | Distance: {GetDistance():0.00}km, Speed: {GetSpeed():0.00} kph, Pace: {GetPace():0.00}  min per km";
    }
}