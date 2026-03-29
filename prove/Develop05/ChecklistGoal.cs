using System;

class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

      public ChecklistGoal() : base()
    {
        _targetCount = 0;
        _currentCount = 0;
        _bonusPoints = 0;
    }

    public ChecklistGoal(string name, string description, int points, bool status, int currentCount, int targetCount, int bonusPoints) : base()
{
    SetLoadedData(name, description, points, status);
    _currentCount = currentCount;
    _targetCount = targetCount;
    _bonusPoints = bonusPoints;
}

    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        SetPoints();

        Console.Write("How many times does this goal need to be completed? ");
        _targetCount = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for completing this goal? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public override int RecordEvent()
    {
        if (GetStatus())
        {
            Console.WriteLine("This checklist goal is already complete.");
            return 0;
        }

        _currentCount++;

        if (_currentCount >= _targetCount)
        {
            SetStatus(true);
            Console.WriteLine("Checklist goal completed! Bonus earned!");
            return GetPointsValue() + _bonusPoints;
        }

        Console.WriteLine("Checklist progress recorded!");
        return GetPointsValue();
    }

    public override string GetConsoleString()
    {
        string checkbox = GetStatus() ? "[X]" : "[ ]";
        return $"{checkbox} {GetName()} ({GetDescription()}) -- Completed {_currentCount}/{_targetCount}";
    }

    public override string GetSaveString()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPointsValue()}|{GetStatus()}|{_currentCount}|{_targetCount}|{_bonusPoints}";
    }
}