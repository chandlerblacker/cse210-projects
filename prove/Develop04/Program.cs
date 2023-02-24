using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;

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
            }
        }




    }
}