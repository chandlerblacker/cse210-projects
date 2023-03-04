public class Simple : Goal
{
    bool _complete = false;


    public Simple(string name, string description, int points) : base (name, description, points)
    {
        
    }

    public override int RecordEvent()
    {
        _complete = true;
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return _complete;
    }
    
    public void SetComplete(bool complete)
    {
        _complete = complete;
    }

    public override string GetCurrentlyComplete()
    {
        return "";
    }

    public override string GetStringRepresentation()
    {
        return $"Simple,{GetName()},{GetDescription()},{GetPoints()},{_complete}";
    }
}
