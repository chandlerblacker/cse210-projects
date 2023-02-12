using System;

public class Word
{
    public void getPhrase(string phrase, List<string> wordList, string reference, List<string> hiddenList)
    {
        Console.WriteLine($"{reference} {phrase}");
        string wholePhrase = phrase;
        string removePhrase = phrase;

        do
        {
            Console.WriteLine("Type 'exit' to quit or hit Enter");
            string answer = Console.ReadLine();
            
            Random random = new Random{};
            int index = random.Next(0, wordList.Count);
            string word = wordList[index];
            string removeWord = hiddenList[index];
            string newWord = "";
            string removeNewWord = "";

            for (int i = 0; i < word.Length; i++)
            {
                newWord += "_";
                removeNewWord += "";
            }
            
            wordList[index] = newWord;
            hiddenList[index] = removeNewWord;

            wholePhrase = "";
            removePhrase = "";

            for (int i = 0; i < wordList.Count; i++)
            {
                wholePhrase += wordList[i].ToString() + " ";
                removePhrase += hiddenList[i].ToString();
            }

            string showPhrase = reference + " " + wholePhrase;

            if (answer != "exit")
            {
                Console.Clear();
                Console.WriteLine(showPhrase);
            }
            else
            {
                Console.WriteLine("");
                break;
            }



        } while (removePhrase.Length > 0);
    }
}