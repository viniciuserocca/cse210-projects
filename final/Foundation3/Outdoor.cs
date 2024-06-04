using System;

class Outdoor : Event
{
    private string _weather;

    public Outdoor (string weather, string title, string description, string date, string time, Address address) : base (title, description, date, time, address)
    {   
        _type = "Outdoor";
        _weather = weather;
    }

    public void GetFullDetails()
    {   
        Console.WriteLine($"\nType: {_type}");
        GetStandardDetails();
        Console.WriteLine($"Weather Statement: {_weather}\n");
    }
}