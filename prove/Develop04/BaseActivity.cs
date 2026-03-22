
class BaseActivity

{
    private string _name;
    private string _description;
    private int _duration;
    

    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public void DisplayGreeting()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
    }

    public void DisplayDescription()
    {
        Console.WriteLine(_description);
    }

    public void SetDuration(int seconds)
    {
        _duration = seconds;
    }

    public int GetDuration()
    {
        return _duration;
    }

     public void DisplayStartingMessage()
    {
        Console.Clear();
        DisplayGreeting();
        Console.WriteLine();
        DisplayDescription();
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        int duration;

        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
        {
            Console.Write("Please enter a valid number: ");
        }

        SetDuration(duration);

        Console.WriteLine();
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();

        Console.WriteLine($"You have completed the {_name} Activity for {_duration} seconds.");
        ShowSpinner(3);
        Console.WriteLine();

        Console.WriteLine("Press Enter to return to the menu.");
        Console.ReadLine();
    }

    public void ShowSpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        string[] spinner = { "|", "/", "-", "\\" };
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[index]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            index++;

            if (index >= spinner.Length)
            {
                index = 0;
            }
        }
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public bool HasTimeExpired(DateTime startTime)
    {
        DateTime endTime = startTime.AddSeconds(_duration);
        return DateTime.Now >= endTime;
    }

    //  public void ShowSpinner(int seconds)
    // {
    //     DateTime currentTime = DateTime.Now;
    //     DateTime endTime = currentTime.AddSeconds(seconds);
    //     int sleepTime = 100; //in miliseconds
    //     string animationString = "-\\|/";
    //     int index = 0;

    //     Console.CursorVisible = false;
    //     // Console.Clear();

    //     Console.Write($"{message} ");

    //     while(DateTime.Now < endTime)
    //     {
    //         Console.Write(animationString[index++ % animationString.Length]);
    //         Thread.Sleep(sleepTime);
    //         Console.Write("\b");
    //     }

    //     Console.CursorVisible = true;
    }





