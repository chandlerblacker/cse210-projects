public class Comments
{
    public string _name;
    public string _text;

    public Comments(string name, string text)
    {
        _name = name;
        _text = text;
    }
    public void Display()
    {
        Console.WriteLine($"{_name}: {_text}");
    }
}