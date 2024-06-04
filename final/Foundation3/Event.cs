using System;

class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    protected string _type;

    public Event (string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void GetStandardDetails()
    {   
        Console.WriteLine($"{_title} - {_description}\n{_date} at {_time}");
        Console.WriteLine(_address.DisplayAddress());
    }

    public void ShortDescription()
    {   
        Console.WriteLine($"{_type} - {_title} - {_date}");
        Console.WriteLine("=======================================\n");
    }
}