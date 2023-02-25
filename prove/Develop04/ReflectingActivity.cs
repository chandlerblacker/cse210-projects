public class ReflectingActivity : Activity
{
    private string _description;
    private int _duration;
    private string _activityName;
    private string _prompt;
    private List<string> _prompts;
    private string _question;
    private List<string> _questions;
    private int _qIndex;

    public ReflectingActivity()
    {
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _activityName = "Reflecting";

        _qIndex = 0;
    }


    public void run()
    {
        List<string> _prompts = new List<string>
        {"Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
        };
        List<string> _questions = new List<string>
        {"Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
        };

        Console.Clear();
        _duration = displayStart(_description, _activityName);
        int time = _duration;

        Console.Clear();
        Console.WriteLine("Get ready...");
        spinner(3);
        Console.WriteLine();
        Console.WriteLine();

        Random rnd = new Random();
        int pIndex = rnd.Next(_prompts.Count());
        _prompt = _prompts[pIndex];
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {_prompt} --- ");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You may begin in: ");
        timer(5);
        Console.Clear();

        do
        {
            _qIndex = rnd.Next(_questions.Count());
            _question = _questions[_qIndex];
            Console.WriteLine($">{_question}");
            spinner(10);
            _duration = _duration - 10;
        }while (_duration > 10);

        _qIndex = rnd.Next(_questions.Count());
        _question = _questions[_qIndex];
        Console.WriteLine($">{_question}");
        spinner(_duration);
        _duration = _duration - 10;

        Console.WriteLine();
        Console.WriteLine("Well done!!");
        spinner(3);
        Console.WriteLine($"You completed another {time} seconds of the Reflecting Activity.");
        spinner(5);
        Console.Clear();
    }

    


}