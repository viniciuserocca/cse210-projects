using System;

class EternalGoal : Goal
{
    public EternalGoal (string name, string description, int points) : base (name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetNameString()
    {
        return _shortName;
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}";
    }
}