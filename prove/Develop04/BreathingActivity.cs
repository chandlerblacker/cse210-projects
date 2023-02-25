public class BreathingActivity : Activity
{
    private string _description;
    private int _duration;
    private string _activityName;
    public BreathingActivity()
    {
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _activityName = "Breathing";
    }

    public void run()
    {
        Console.Clear();
        _duration = displayStart(_description, _activityName);
        int time = _duration;

        Console.Clear();
        Console.WriteLine("Get ready...");
        spinner(3);
        Console.WriteLine();
        Console.WriteLine();
        do
        {
            Console.WriteLine("Breathe in...");
            timer(4);
            Console.WriteLine("Now breathe out...");
            timer(6);
            _duration = _duration - 10;
            Console.WriteLine();
        }while (_duration > 10);

        Console.WriteLine("Breathe in...");
        timer(_duration / 2);
        Console.WriteLine("Now breathe out...");
        timer(_duration / 2);
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        spinner(3);
        Console.WriteLine($"You completed another {time} seconds of the Breathing Activity.");
        spinner(5);
        Console.Clear();


    }

}