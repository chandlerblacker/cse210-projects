using System;

public class Scriptures
{
    private string _phrase;


    public Scriptures(string wholePhrase)
    {
        _phrase = wholePhrase;
    }

    public string getWholePhrase()
    {
        string newPhrase = _phrase;
        return newPhrase;
    }
}