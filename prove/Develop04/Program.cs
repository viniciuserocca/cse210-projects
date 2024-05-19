using System;

// Exceeding the Requirements
// "Make sure no random prompts/questions are selected until they have all been used at least once in that session."

// Inside the ReflectingActivity class the method GetRandomQuestion checks if the question wasn't displayed before.
// And if all the questions on the list are displayed, it will reset the validation to start over again.

class Program
{
    static void Main(string[] args)
    {
        var choice = "";
        do
        {   
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity b = new BreathingActivity();
                b.Run();
            }

            else if (choice == "2")
            {
                ReflectingActivity r = new ReflectingActivity();
                r.Run();
            }

            else if (choice == "3")
            {
                ListingActivity l = new ListingActivity();
                l.Run();
            }
        }
        while (choice != "4");
    }
}