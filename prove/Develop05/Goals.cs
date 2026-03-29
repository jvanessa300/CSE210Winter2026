using System;
using System.Collections.Generic;

class Goals
{
    private List<Goal> _goalList;
    private int _score;

    public Goals()
    {
        _goalList = new List<Goal>();
        _score = 0;
    }

    public void AddGoal(Goal newGoal)
    {
        _goalList.Add(newGoal);
    }

    public void DisplayGoalList()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goalList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goalList[i].GetConsoleString()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"\nYou have {_score} points.");
    }

    public void RecordGoalEvent()
    {
      if (_goalList.Count == 0)
        {
            Console.WriteLine("There are no goals to record.");
            return;
        }

        DisplayGoalList();
        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());

        Goal selectedGoal = _goalList[choice - 1];
        int earnedPoints = selectedGoal.RecordEvent();
        _score += earnedPoints;

        Console.WriteLine($"You earned {earnedPoints} points.");
        Console.WriteLine($"You now have {_score} points!");
    }

    public void SaveFile()
    {
        Console.Write("Enter filename to save goals: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goalList)
            {
                outputFile.WriteLine(goal.GetSaveString());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadFile()
    {
        Console.Write("Enter filename to load goals: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);

            _goalList.Clear();
            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                // Console.WriteLine($"Loaded: {lines[i]}");
                string[] parts = lines[i].Split("|");
                string goalType = parts[0];

            if (goalType == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool status = bool.Parse(parts[4]);

                SimpleGoal simpleGoal = new SimpleGoal(name, description, points, status);
                _goalList.Add(simpleGoal);
            }
             else if (goalType == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goalList.Add(eternalGoal);
            }
            else if (goalType == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool status = bool.Parse(parts[4]);
                int currentCount = int.Parse(parts[5]);
                int targetCount = int.Parse(parts[6]);
                int bonusPoints = int.Parse(parts[7]);

                ChecklistGoal checklistGoal = new ChecklistGoal(
                    name, description, points, status, currentCount, targetCount, bonusPoints
                );
                _goalList.Add(checklistGoal);
            }
        }

            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
        
    }

}