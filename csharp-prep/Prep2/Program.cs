using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your score: ");
        string inputFromUser = Console.ReadLine();    

        int score = int.Parse(inputFromUser);
        string letter = "";
        string sign = "";

        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else if (score < 60)
        {
            letter = "F";
        }

        int lastDigit = score % 10;
        Console.WriteLine(lastDigit);

        if (lastDigit >= 7 && letter != "A" && letter != "F")
        {
            sign = "+";
        }
        else if (lastDigit < 3 && letter != "F")
        {
            sign = "-";
        }
        else
            sign = "";

        Console.WriteLine($"Your grade is {letter}{sign}");

        if (score >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't make it. Good luck next time!");
        }

    }
}