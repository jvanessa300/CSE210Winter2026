
class SimpleGoal : Goal
{
    // public SimpleGoal() : base()
    // {  
    // }
       public SimpleGoal() : base()
    {
    }
    public SimpleGoal(string name, string description, int points, bool status) : base()
    {
        SetLoadedData(name, description, points, status);
    }

    public override void CreateGoal()
    {
        base.SetName();
        base.SetDescription();
        base.SetPoints();
    }

     public override int RecordEvent()
    {
        // SetStatus(true);
        // Console.WriteLine("Goal completed! 🎉");
         if (GetStatus() == false)
        {
            SetStatus(true);
            Console.WriteLine("Goal completed!");
            return GetPointsValue();
        }
        else
        {
            Console.WriteLine("This goal is already complete.");
            return 0;
        }

    }

    public override string GetConsoleString()
    {
        string checkbox = GetStatus() ? "[X]" : "[ ]";
        return $"{checkbox} {GetName()} ({GetDescription()})";
    }

      public override string GetSaveString()
    {
        return $"SimpleGoal|{GetName()}|{GetDescription()}|{GetPointsValue()}|{GetStatus()}";
    }

}