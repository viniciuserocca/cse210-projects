using System;

class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _count = 0;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        
        Console.Write($"You may begin in: ");
        ShowCountDown(8);
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

         while (DateTime.Now < endTime)
        {      
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }

        Console.WriteLine("");
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);

        string prompt = _prompts[index];

        Console.WriteLine($"--- {prompt} ---");
    }

    public List<string> GetListFromUser()
    {
        return _prompts;
    }
}