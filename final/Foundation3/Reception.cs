using System;

class Reception : Event
{
    private string _email;

    public Reception (string email, string title, string description, string date, string time, Address address) : base (title, description, date, time, address)
    {   
        _type = "Reception";
        _email =email;
    }

    public void GetFullDetails()
    {   
        Console.WriteLine($"\nType: {_type}");
        GetStandardDetails();
        Console.WriteLine($"Email: {_email}\n");
    }
}