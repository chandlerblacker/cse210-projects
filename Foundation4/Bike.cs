public class Bike : Activity
{
    private double _speed;

    public Bike(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return Math.Round(GetLength() / _speed, 2);
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
        return $"{GetDate()} Biking ({GetLength()} min)- Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}