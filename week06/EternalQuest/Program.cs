using System;
using System.Collections.Generic;
using System.IO;
// The main Program.cs file to run the application.
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}