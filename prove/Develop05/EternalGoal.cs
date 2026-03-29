
class EternalGoal : Goal
{
    // public EternalGoal() : base()
    // {
    // }

    public EternalGoal() : base()
    {
    }
    public EternalGoal(string name, string description, int points) : base()
    {
        SetLoadedData(name, description, points, false);
    }

    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        SetPoints();
    }

    public override int RecordEvent()
    {
        Console.WriteLine("Eternal goal recorded!");
        return GetPointsValue();
    }

    public override string GetConsoleString()
    {
        return $"[∞] {GetName()} ({GetDescription()})";
    }

    public override string GetSaveString()
    {
        return $"EternalGoal|{GetName()}|{GetDescription()}|{GetPointsValue()}";
    }
}