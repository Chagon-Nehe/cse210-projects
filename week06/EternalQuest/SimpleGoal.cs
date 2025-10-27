using System;
using System.Collections.Generic;

namespace Goals
{
    // A simple goal that can only be completed once.
    public class SimpleGoal : Goal
    {
        private bool _isComplete;

        public SimpleGoal(string name, string description, int points) : base(name, description, points)
        {
            _isComplete = false;
        }

        public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
        {
            _isComplete = isComplete;
        }

        public override void RecordEvent()
        {
            if (!_isComplete)
            {
                _isComplete = true;
                Console.WriteLine($"Congratulations! You have completed the goal and earned {_points} points!");
            }
            else
            {
                Console.WriteLine("This goal has already been completed.");
            }
        }

        public override bool IsComplete()
        {
            return _isComplete;
        }

        public override string GetDetailsString()
        {
            string status = IsComplete() ? "[X]" : "[ ]";
            return $"{status} {base.GetDetailsString()}";
        }

        public override string GetStringRepresentation()
        {
            return $"SimpleGoal:{GetName()},{GetDescription()},{_points},{_isComplete}";
        }
    }
}
