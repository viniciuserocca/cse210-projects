using System;

class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event ()
    {

    }

    public string GetStandardDetails()
    {
        return "";
    }

    public string GetFullDetails()
    {
        return "";
    }

    public string ShortDescription()
    {
        return "";
    }
}