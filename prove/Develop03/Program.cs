using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> wordList = new List<string>()
        {
            "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed."
        };

        Reference reference = new Reference("James", "1", "5", "6");
        var referenceOne = reference.getReference();
        Scriptures scripture = new Scriptures(wordList[0]);
        var scriptureOne = scripture.getWholePhrase();

        List<string> list = new ();
        list = scriptureOne.Split(" ").ToList();
        List<string> removeList = new ();
        removeList = scriptureOne.Split(" ").ToList();

        Word word = new Word();
        word.getPhrase(scriptureOne, list, referenceOne, removeList);
    }
}