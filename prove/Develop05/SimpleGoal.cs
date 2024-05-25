using System;
using System.Text.Encodings.Web;

class SimpleGoal : Goal
{
    private bool _isComplete = false;
    
    public SimpleGoal (string name, string description, int points, bool isComplete) : base (name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {   
        if (_isComplete == true)
        {
            _points = 0;
        }
        else 
        {
            _isComplete = true;
        }
        return _points;
    }

    public override bool IsComplete()
    {   
        return _isComplete;
    }

    public override string GetNameString()
    {
        return _shortName;
    }

    public override string GetStringRepresentation()
    {      
        return $"{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}