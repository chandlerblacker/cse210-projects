public class Checklist : Goal
{
    bool _complete = false;
    int _timesToGoal;
    int _timesCompleted = 0;
    int _bonusPoints;
    int _returnPoints;

    public Checklist(string name, string description, int points, int timesToGoal, int bonusPoints) : base (name, description, points)
    {
        _timesToGoal = timesToGoal;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        _timesCompleted += 1;
        if (_timesCompleted >= _timesToGoal) {_complete = true;}
        _returnPoints = GetPoints();
        if (_timesCompleted == _timesToGoal) {_returnPoints += _bonusPoints;}
        
        return _returnPoints;
    }

    public void SetTimesCompleted(int timesCompleted)
    {
        _timesCompleted = timesCompleted;
    }

    public override bool IsComplete()
    {
        return _complete;
    }

    public override string GetCurrentlyComplete()
    {
        return $" --- Currently completed: {_timesCompleted}/{_timesToGoal}";
    }
    public override string GetStringRepresentation()
    {
        return $"Checklist,{GetName()},{GetDescription()},{GetPoints()},{_bonusPoints},{_timesCompleted},{_timesToGoal}";
    }
}
