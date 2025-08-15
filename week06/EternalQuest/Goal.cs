using System;
using System.Collections.Generic;
// The base class for all goal types.
public abstract class Goal
{
    // Private member variables to encapsulate data.
    protected string _shortName;
    protected string _description;
    protected int _points; // Protected to be accessible by derived classes.

    // Constructor for the base class.
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Abstract methods that must be overridden by derived classes.
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    // A virtual method that can be overridden but doesn't have to be.
    public virtual string GetDetailsString()
    {
        return $"{_shortName} ({_description})";
    }

    // A getter for the points value.
    public int GetPoints()
    {
        return _points;
    }
}