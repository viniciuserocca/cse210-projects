using System;

abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {   
        string checkBox = " ";
        if (IsComplete() == true)
        {
            checkBox = "X";
        }
        return $"[{checkBox}] {_shortName} ({_description})";
    }

    public abstract string GetNameString();

    public abstract string GetStringRepresentation();
}