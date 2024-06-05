using System;

public abstract class Activity
{
    protected string _date;
    protected double _minutes;
    protected string _name;

    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    public string GetSummary()
    {   
        double distance = Math.Round(CalculateDistance(), 3);
        double speed = Math.Round(CalculateSpeed(), 2);
        double pace = Math.Round(CalculatePace(), 2);

        return $"{_date} {_name} ({_minutes}): Distance {distance} miles, Speed: {speed} mph, Pace: {pace} min per mile";
    }

    public abstract double CalculateDistance();

    public abstract double CalculateSpeed();

    public abstract double CalculatePace();
}