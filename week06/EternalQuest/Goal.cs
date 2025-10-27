using System;
using System.Collections.Generic;
using System.IO;

// This is the base class for all goals.
// It uses encapsulation to protect its data.
// It defines abstract methods that must be implemented by derived classes.
public abstract class Goal
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

    // Getters for the name and description.
    public string GetName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }

    // Abstract methods to be overridden by derived classes, demonstrating polymorphism.
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
    
    // Virtual method for displaying goal details, can be overridden.
    public virtual string GetDetailsString()
    {
        return $"{_shortName} ({_description})";
    }

    // This method returns the points associated with the goal.
    public int GetPoints()
    {
        return _points;
    }
}