public class Run : Activity
{
    private double _distance;

    public Run(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return Math.Round(60 / GetPace(), 2);
    }

    public override double GetPace()
    {
        return  Math.Round((GetLength() / _distance), 2);
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetLength()} min)- Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}