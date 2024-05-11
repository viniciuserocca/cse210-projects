using System;

// Exceeding the Requirements
// This program will randomly select an scripture from the scriptures.txt file,
// And this program will only hide the words that's not been hidden previously.
class Program
{
    static void Main(string[] args)
    {   
        string userInput;
        string book = "";
        string chapter = "";
        string verse = "";
        string endVerse = "";
        string text = "";

        string[] line = System.IO.File.ReadAllLines("scriptures.txt");

        var random = new Random();
        int index = random.Next(line.Count());

        string[] parts = line[index].Split("|");
        book = parts[0];
        chapter = parts[1];
        verse = parts[2];
        endVerse = parts[3];
        text = parts[4];

        Reference reference = new Reference(book, int.Parse(chapter), int.Parse(verse), int.Parse(endVerse));
        Scripture scripture = new Scripture(reference, text);

        do 
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden() == false)
            {
                scripture.HideRandomWords(3);
            }
            else
            {
                break;
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();
        }
        while (userInput != "quit");
    }
}