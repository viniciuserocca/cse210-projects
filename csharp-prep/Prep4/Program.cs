using System;

class Program
{
    static void Main(string[] args)
    {   
        string userInput = "";
        int sum = 0;
        int largest = 0;
        int smallest = 999999;

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userInput != "0")
        {
            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        foreach (int value in numbers)
        {
            sum += value;

            if (value > largest)
            {
                largest = value;
            }   

            if (value < smallest && value > 0)
            {
                smallest = value;
            }
        }

        float average = ((float)sum) / (numbers.Count);

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");

        numbers.Sort();
        Console.WriteLine($"The sorted list is:");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
    
    }
}