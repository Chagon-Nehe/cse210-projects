using System;
using System.Collections.Generic;

// ChecklistGoal class inherits from Goal.
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // Override RecordEvent.
    public override void RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted++;
        }
    }

    // Override IsComplete.
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    // Override GetDetailsString to show progress.
    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{_target}";
    }

    // Override GetStringRepresentation.
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}