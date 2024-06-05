using System;

class Swimming : Activity
{
    private int _laps;

    public Swimming (string date, double minutes, int laps) : base (date, minutes)
    {   
        _name = "Swimming";
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        return _laps * (double)50 / 1000 * 0.62;
    }

    public override double CalculateSpeed()
    {
        double distance = CalculateDistance();
        return (distance / _minutes) * 60;
    }

    public override double CalculatePace()
    {
        double distance = CalculateDistance();
        return _minutes / distance;
    }
}