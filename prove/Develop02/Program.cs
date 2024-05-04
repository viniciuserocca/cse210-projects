using System;
using System.Collections.Generic;

// Showing Creativity and Exceeding the Requirements
// This program has an extra option which gives you the possibility of seeing an information about how many days are registred in the journal.

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Welcome to the Journal Program");

        string option;
        string filename;

        Journal journal = new Journal();
        PromptGenerator p = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Show dates registred"); //Exceeding the Requirements
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");
            option = Console.ReadLine();

            if (option == "1")
            {
                Console.WriteLine();
                string prompt = p.GetRandomPrompt();
                Console.WriteLine(prompt);
                string answer = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string date = theCurrentTime.ToShortDateString();

                Entry entry = new Entry();
                entry._date = date;
                entry._promptText = prompt;
                entry._entryText = answer;

                journal.AddEntry(entry);
            }

            else if (option == "2")
            {   
                Console.WriteLine();
                journal.DisplayAll();
            }

            else if (option == "3")
            {   
                Console.WriteLine();
                Console.WriteLine("What is the file name? ");
                filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }

            else if (option == "4")
            {   
                Console.WriteLine();
                Console.WriteLine("What is the file name? ");
                filename = Console.ReadLine();
                journal.SaveFile(filename);
            }

            else if (option == "5") //Exceeding the Requirements
            {
                Console.WriteLine();
                journal.ShowInfo();
            }

            else if (option == "6")
            {
                break;
            }

            else 
            {   
                Console.WriteLine();
                Console.WriteLine("Invalid option!");
                Console.WriteLine();
            }
        }
    }
}