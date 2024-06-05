using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // Creating Events
        Running r = new Running("01/01/2024", 90, 3);
        Cycling c = new Cycling("02/02/2024", 60, 15);
        Swimming s = new Swimming("03/03/2024", 20, 5);

        // Displaying Events
        Console.WriteLine(r.GetSummary());
        Console.WriteLine(c.GetSummary());
        Console.WriteLine(s.GetSummary());

    }
}