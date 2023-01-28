using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
       bool exit = false;

       Journal journal = new Journal();

       List<string> questions = new List<string>()
       {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Who did I help the most today?",
        "What did I learn today?"

       };
        Console.WriteLine("What is your name? ");
        string name = Console.ReadLine();
        Console.WriteLine($"{name}'s journal");

        while(!exit)
        {
            Console.WriteLine("Please choose an option below:");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Load journal");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            
            string choice = Console.ReadLine();

        

            switch(choice)
            {
                case "1":
                Random random = new Random();
                Entry newEntry = new Entry();
                newEntry._question = questions[random.Next(0,6)];
                Console.WriteLine(newEntry._question);
                newEntry._answer = Console.ReadLine();
                journal._entries.Add(newEntry);
                break;

                case "2":
                journal.Display();
                break;

                case "3":
                Console.Write("What is the name of the file?");
                string[] contents = System.IO.File.ReadAllLines(Console.ReadLine());
                foreach (string content in contents)
                {
                    Console.WriteLine(content);
                }
                break;

                case "4":
                Console.Write("Save file as: ");
                string fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName) )
                {
                    foreach (Entry entry in journal._entries)
                    {
                        outputFile.WriteLine($"Date:{entry._date}  Prompt: {entry._question} Response: {entry._answer}");
                    }
                }
                break;

                case "5":
                    exit = true;
                break;

            }
        }    
    }
}