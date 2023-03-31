public class Event
{

    public Event()
    {

    }

    public void standardD(string title, string description, string date, string time, string address)
    {
        Console.WriteLine($"{title}\n{description}, {date}, {time}\n{address}");
    }

    public void shortD(string type, string title, string date)
    {
        Console.WriteLine($"{type}, {title}, {date}\n");
    }

}