using System;

public class Entry
{
    public string _question = "";
    public string _answer = "";
    public string _date = DateTime.Now.ToString("MM-dd-yyyy");
    public void Display()
    {
        Console.WriteLine($"Date:{_date}  Prompt: {_question} Response: {_answer}");
    }
}