using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        int totalPoints = 0;
        int choice;
        int goalType;
        string name;
        string description;
        int points;
        string currentlyComplete;
        string completed;
        int goalNum;
        int accomplished;
        List<Goal> goals = new List<Goal>();

        do
        {
            Console.WriteLine();
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
            choice = Int32.Parse(Console.ReadLine());


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
                Console.WriteLine("What is a short description of it?");
                description = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated with this goal? ");
                points = Int32.Parse(Console.ReadLine());

                if (goalType == 1)
                {
                    Simple s1 = new Simple(name, description, points);
                    goals.Add(s1);
                }
                else if (goalType == 2)
                {
                    Eternal e1 = new Eternal(name, description, points);
                    goals.Add(e1);
                }
            }

            else if (choice == 2)
            {
                Console.WriteLine("The goals are:");
                goalNum = 0;
                foreach (Goal g in goals)
                {
                    goalNum += 1;
                    currentlyComplete = " ";
                    completed = "[ ]";
                    if (g.IsComplete()) {completed = "[X]";}
                    name = g.GetName();
                    description = g.GetDescription();
                    Console.WriteLine($"{goalNum}. {completed} {name} ({description}) {currentlyComplete}");

                }
            }

            else if (choice == 3)
            {


            }

            else if (choice == 4)
            {


            }

            else if (choice == 5)
            {
                Console.WriteLine("The goals are:");
                goalNum = 0;
                foreach (Goal g in goals)
                {
                    goalNum += 1;
                    name = g.GetName();
                    Console.WriteLine($"{goalNum}. {name}");
                }

                Console.WriteLine("Which goal did you accomplish?");
                accomplished = Int32.Parse(Console.ReadLine());
                points = goals[accomplished - 1].RecordEvent();
                Console.WriteLine($"Congratulations! You have earned {points} points");
                totalPoints += points;
            }

            else if (choice == 6)
            {
                break;
            }
        }while(!quit);
    }
}