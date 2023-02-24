public class BreathingActivity : Activity
{
    private string _description;
    private string _duration;
    public BreathingActivity(string duration)
    : base(duration)
    {
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void run()
    {
        _duration = displayStart(_description);
        
        Console.Clear();
        Console.WriteLine("Get ready...");
        Console.WriteLine();
        Console.WriteLine();
        
        Console.WriteLine
    }

    public string GetDescription()
    {
        return _description;
    }
}