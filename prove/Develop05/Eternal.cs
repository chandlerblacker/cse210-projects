public class Eternal : Goal
{
    public Eternal(string name, string description, int points) : base (name, description, points)
    {
        
    }

    public override int RecordEvent()
    {
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return false;
    }
}