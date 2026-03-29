


abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _numberOfPoints;
    protected bool _status;
    // private string _goalType;

    public Goal()
    {
        _name = "";
        _description = "";
        _status = false;
        _numberOfPoints = 0;
        // _goalType = "";
    }

    public void SetName()
    {
        Console.WriteLine("Please the enter name of your goal: ");
        _name = Console.ReadLine();
    }

     public void SetDescription()
    {
        Console.WriteLine("Please the enter description of your goal: ");
        _description = Console.ReadLine();
    }

    public void SetPoints()
    {
         Console.WriteLine("Please the enter Points for your goal: ");
        _numberOfPoints = int.Parse(Console.ReadLine());
    }

    public virtual string GetConsoleString()
    {
        return $"Goal Information: {_name}";
    }


    public string GetName()
    {
        return _name;
    }
     public string GetDescription()
    {
        return _description;
    }

    public int GetPointsValue()
    {
        return _numberOfPoints;
    }

    public bool GetStatus()
    {
        return _status;
    }

    public void SetStatus(bool status)
    {
        _status = status;
    }

    public abstract void CreateGoal();
    public abstract int RecordEvent();
    public abstract string GetSaveString();

    protected void SetLoadedData(string name, string description, int points, bool status)
    {
        _name = name;
        _description = description;
        _numberOfPoints = points;
        _status = status;
    }

}
