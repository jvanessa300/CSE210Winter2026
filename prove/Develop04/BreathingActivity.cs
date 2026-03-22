


class BreathingActivity : BaseActivity
{
    private int _breathInTime;
    private int _breathOutTime;

    public BreathingActivity()
        : base(
            "Breathing",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        _breathInTime = 4;
        _breathOutTime =6;
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;

        while (!HasTimeExpired(startTime))
        {
            PerformBreathingCycle();
        }

        DisplayEndingMessage();
    }

    private void PerformBreathingCycle()
    {
        Console.WriteLine();
        Console.Write("Breathe in...");
        ShowCountdown(_breathInTime);
        Console.WriteLine();

        Console.Write("Breathe out...");
        ShowCountdown(_breathOutTime);
        Console.WriteLine();
    }
    
}