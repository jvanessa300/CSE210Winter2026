


using System.Diagnostics.CodeAnalysis;

class ListingActivity : BaseActivity
{
    private List<string> _prompts;
    private List<string> _items;
    private Random _random;

    public ListingActivity()
        : base(
            "Listing",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this months?",
            "Who are some of your personal heroes?"
        };

        _items = new List<string>();
        _random = new Random();
    }

    public void Run()
    {
        DisplayStartingMessage();
        _items.Clear();

        DisplayPrompt();
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();
        Console.WriteLine();

        GetListFromUser();
        DisplayItemCount();

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    private void DisplayPrompt()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();
    }

    private void GetListFromUser()
    {
        DateTime startTime = DateTime.Now;

        while (!HasTimeExpired(startTime))
        {
            Console.Write("> ");
            string item = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(item))
            {
                _items.Add(item);
            }
        }
    }

    private void DisplayItemCount()
    {
        Console.WriteLine();
        Console.WriteLine($"You listed {_items.Count} items!");
    }

}