using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        int breatheCount = 0;
        int reflectCount = 0;
        int listCount = 0;


        while(quit == false)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            int choice = Convert.ToInt16(Console.ReadLine());

            if (choice == 1)
            {
                BreathingActivity b1 = new BreathingActivity();
                b1.run();
                breatheCount += 1;
            }

            else if (choice == 2)
            {
                ReflectingActivity r1 = new ReflectingActivity();
                r1.run();
                reflectCount += 1;
            }

            else if (choice == 3)
            {
                ListingActivity l1 = new ListingActivity();
                l1.run();
                listCount += 1;
            }

            else if (choice == 4)
            {
                Console.Clear();
                Console.WriteLine($"You completed the Breathing activity {breatheCount} times.");
                Console.WriteLine($"You completed the Reflecting activity {reflectCount} times.");
                Console.WriteLine($"You completed the Listing activity {listCount} times.");
                break;
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Please type 1, 2, 3, or 4 to select");
            }
        }




    }
}