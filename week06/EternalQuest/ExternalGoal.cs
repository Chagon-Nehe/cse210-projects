using System;
using System.Collections.Generic;
using System.IO;

// EternalGoal class inherits from Goal.
public class EternalGoal : Goal
{
    // Constructor.
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    // Override RecordEvent. The goal is never complete, so we just gain points.
    public override void RecordEvent()
    {
        // No change in state, just a score update.
    }

    // Override IsComplete. This goal is never complete.
    public override bool IsComplete()
    {
        return false;
    }

    // Override GetStringRepresentation.
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}