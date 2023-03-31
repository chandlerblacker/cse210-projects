public class Swim : Activity
{
    private double _laps;

    public Swim(string date, int length, double laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return Math.Round(_laps * 50 / 1000, 2);
    }

    public override double GetSpeed()
    {
        return Math.Round(60 / GetPace(), 2);
    }

    public override double GetPace()
    {
        return Math.Round(GetLength() / GetDistance(), 2);
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetLength()} min)- Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}