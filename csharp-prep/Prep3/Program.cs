using System;

class Program
{
    static void Main(string[] args)
    {   
        string play = "yes";

        while (play == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);

            Console.WriteLine("Guess a number between 1 and 100");

            int guess = 0;
            int count = 0;

            while (guess != number)
            {
                Console.Write("What is your guess? ");
                string userInput = Console.ReadLine();
                guess = int.Parse(userInput);
                count ++;

                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
            Console.WriteLine($"It took you {count} guesses");
            Console.WriteLine("Do you wanna play it again? (yes/no) ");
            play = Console.ReadLine();
        }
        Console.WriteLine("Thanks for playing");
    }
}