using System;

class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture (string speaker, int capacity, string title, string description, string date, string time, Address address) : base (title, description, date, time, address)
    {   
        _type = "Lecture";
        _speaker = speaker;
        _capacity = capacity;
    }

    public void GetFullDetails()
    {   
        Console.WriteLine($"\nType: {_type}");
        GetStandardDetails();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}\n");
    }
}