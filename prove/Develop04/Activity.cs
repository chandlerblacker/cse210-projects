public class Activity
{
    // activityNum 1 = BreathingActivity, 2 = ReflectingActivity, 3 = ListingActivity
    private string _activityName;
    private string _duration;

    public Activity(string activityName)
    {
        _activityName = activityName;
    }

    public string displayStart(string description)
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity.");
        Console.WriteLine(description);
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _duration = Console.ReadLine();
        return _duration;
    }

    public void timer(int length)
    {
        do
        {
            Console.Write(length);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            length = length - 1;
        }while (length > 0);
    }

    public void spinner(int length)
    {
        do
        {
            Console.Write('/');
            Thread.Sleep(333);
            Console.Write("\b \b");
            Console.Write('-');
            Thread.Sleep(333);
            Console.Write("\b \b");
            Console.Write(@"\");
            Thread.Sleep(333);
            Console.Write("\b \b");
            length = length - 1;
        }
    }
}