using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        int totalPoints = 0;
        int choice = 0;
        int goalType = 0;
        string name;


        do
        {
            Console.WriteLine($"You have {totalPoints} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            choice = Console.Read();


            if (choice == 1)
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.WriteLine("Which type of goal would you like to create? ");
                goalType = Int32.Parse(Console.ReadLine());
                Console.WriteLine("What is the name of the goal?");
                name = Console.ReadLine();

            }


        }while(!quit);
    }
}