using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Run r1 = new Run("30 Sep 2023", 30, 5.2);
        activities.Add(r1);

        Bike b1 = new Bike("15 Jun 2023", 60, 18.4);
        activities.Add(b1);

        Swim s1 = new Swim("12 Jan 2023", 15, 8);
        activities.Add(s1);

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }

    }
}