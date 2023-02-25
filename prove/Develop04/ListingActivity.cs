public class ListingActivity : Activity
{
    private string _description;
    private int _duration;
    private string _activityName;
    private string _prompt;
    private List<string> _prompts;
    private DateTime _currentTime;

    public ListingActivity()
    {
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _activityName = "Listing";
    }

    public void run()
    {
        Console.Clear();
        _duration = displayStart(_description, _activityName);

        List<string> _prompts = new List<string>
        {"Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
        };

        Console.Clear();
        Console.WriteLine("Get ready...");
        spinner(3);
        Console.WriteLine();
        
        Random rnd = new Random();
        int pIndex = rnd.Next(_prompts.Count());
        _prompt = _prompts[pIndex];
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {_prompt} --- ");
        Console.WriteLine("You may begin in:");
        timer(5);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        int itemsListed = 0;
        bool exit = false;
        do
        {
            Console.Write("> ");
            Console.ReadLine();
            itemsListed += 1;
            DateTime _currentTime = DateTime.Now;
            if (_currentTime > futureTime){exit = true;}
        }while (!exit);

        Console.WriteLine($"You listed {itemsListed} items!");
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        spinner(3);
        Console.WriteLine($"You completed another {_duration} seconds of the Listing Activity.");
        spinner(5);
        Console.Clear();
    }

}