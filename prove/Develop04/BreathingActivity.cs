using System;

class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {   
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

         while (DateTime.Now < endTime)
        {   
            Console.WriteLine("");
            Console.Write("Breathe In ...");
            ShowCountDown(4);
            Console.WriteLine("");
            Console.Write("Breathe Out ...");
            ShowCountDown(6);
            Console.WriteLine("");
        }
        
        DisplayEndingMessage();
    }
}