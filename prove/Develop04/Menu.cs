

using System; 

class Menu
{
    private int _choice;

    public Menu()
    {
        _choice = 0;
    }

    public void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Start breathing activity");
        Console.WriteLine(" 2. Start reflecting activity");
        Console.WriteLine(" 3. Start listing activity");
        Console.WriteLine(" 4. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    public int GetMenuChoice()
    {
        string input = Console.ReadLine();
        int choice;

        while(!int.TryParse(input, out choice) || choice < 1 || choice > 4)
        {
            Console.Write("Please enter a valid choice (1-4): ");
            input = Console.ReadLine();
        }

        _choice = choice;
        return _choice;
    }

    public void StartSelectedActivity(int choice)
    {
        if (choice == 1)
        {
            BreathingActivity activity = new BreathingActivity();
            activity.Run();
        }
        else if (choice == 2)
        {
            ReflectingActivity activity = new ReflectingActivity();
            activity.Run();
        }
        else if (choice == 3)
        {
            ListingActivity activity = new ListingActivity();
            activity.Run();
        }
    }

    public void Start()
    {
        bool done = false;

        while (!done)
        {
            DisplayMenu();
            int choice = GetMenuChoice();

            if (choice == 4)
            {
                done = true;
            }
            else
            {
                StartSelectedActivity(choice);
            }
        }
    }

}