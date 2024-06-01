using System;

public abstract class Activity
{
    protected string _date;
    protected double _minutes;
    private List<Activity> _activity = new List<Activity>();

    public Activity()
    {

    }
    public string GetSummary()
    {
        return $"03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km";
    }

    public virtual double CalculateDistance()
    {
        return 0;
    }
    public double CalculateSpeed()
    {
        return 0;
    }
    public virtual double CalculatePace()
    {
        return 0;
    }
}