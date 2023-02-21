using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment a1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine(a1.GetHomeworkList());

        WritingAssignment a2 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetWritingInformation());
    }
}