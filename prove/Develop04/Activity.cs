public class Activity
{
    // activityNum 1 = BreathingActivity, 2 = ReflectingActivity, 3 = ListingActivity
    private int _duration;

    public Activity()
    {

    }

    public int displayStart(string description, string activityName)
    {
        Console.WriteLine($"Welcome to the {activityName} Activity.");
        Console.WriteLine(description);
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _duration = Convert.ToInt32(Console.ReadLine());
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

    public void spinner(double length)
    {
        do
        {
            Console.Write('/');
            Thread.Sleep(166);
            Console.Write("\b \b");
            Console.Write('-');
            Thread.Sleep(166);
            Console.Write("\b \b");
            Console.Write(@"\");
            Thread.Sleep(166);
            Console.Write("\b \b");
            length = length - 0.5;
        }while (length > 0);
    }

}