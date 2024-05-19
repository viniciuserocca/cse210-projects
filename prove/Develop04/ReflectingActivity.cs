using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class ReflectingActivity : Activity
{
    private List<string> check = new List<string>();
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity()
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void Run()
    {   
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        DisplayPrompt();

        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue.");

        while (Console.ReadKey().Key != ConsoleKey.Enter) 
        {
            Console.SetCursorPosition( 0, Console.CursorTop );
        }
        Console.WriteLine("");

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write($"You may begin in: ");
        ShowCountDown(6);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

         while (DateTime.Now < endTime)
        {   
            DisplayQuestions();
            ShowSpinner(10);
            Console.WriteLine("");
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {   
        var random = new Random();
        int index = random.Next(_prompts.Count);

        string selectedPrompt = _prompts[index];

        return selectedPrompt;
    }

    public string GetRandomQuestion()
    {   
        bool validation = false;
        string selectedQuestion = "";

        while (validation != true)
        {   
            var random = new Random();
            int index = random.Next(_questions.Count);

            if (!check.Contains(_questions[index]))
            {
                selectedQuestion = _questions[index];
                check.Add(selectedQuestion);
                validation = true;
            }

            if (check.Count >= _questions.Count)
            {
                check.Clear();
            }
        }

        return selectedQuestion;
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
    }

    public void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        Console.Write($"> {question} ");
    }
}