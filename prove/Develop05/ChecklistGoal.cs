using System;

class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal (string name, string description, int points, int amountCompleted, int target, int bonus) : base (name, description, points)
    {   
        _shortName = name;
        _description = description;
        _points = points;
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {   
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            _points += _bonus;
        }
        else if (_amountCompleted > _target)
        {
            _points = 0;
            _amountCompleted = _target;
        }
        return _points;
    }

    public override bool IsComplete()
    {   
        bool isComplete = false;
        if (_amountCompleted >= _target)
        {
            isComplete = true;
        }
        return isComplete;
    }

    public override string GetDetailsString()
    {
        string checkBox = " ";
        if (IsComplete() == true)
        {
            checkBox = "X";
        }
        return $"[{checkBox}] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetNameString()
    {
        return _shortName;
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }
}