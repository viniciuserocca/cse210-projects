using System;

class Cycling : Activity
{
    private double _speed;

    public Cycling (string date, double minutes, double speed) : base (date, minutes)
    {   
        _name = "Cycling";
        _speed = speed;
    }   

    public override double CalculateDistance()
    {
        return _speed * (_minutes / 60);
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override double CalculatePace()
    {
        return 60 / _speed;
    }
}