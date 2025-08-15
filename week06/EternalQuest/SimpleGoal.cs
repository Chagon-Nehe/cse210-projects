using System;
using System.Collections.Generic;

namespace Goals
{
    // SimpleGoal class inherits from Goal.
    public class SimpleGoal : Goal
    {
        private bool _isComplete;

        public SimpleGoal(string name, string description, int points) : base(name, description, points)
        {
            _isComplete = false;
        }

        // Override the abstract methods.
        public override void RecordEvent()
        {
            _isComplete = true;
        }

        public override bool IsComplete()
        {
            return _isComplete;
        }

        // Override the GetDetailsString to show completion status.
        public override string GetDetailsString()
        {
            string status = _isComplete ? "[X]" : "[ ]";
            return $"{status} {base.GetDetailsString()}";
        }

        // Override GetStringRepresentation for saving to a file.
        public override string GetStringRepresentation()
        {
            return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
        }
    }
}