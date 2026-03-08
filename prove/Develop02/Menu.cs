
class Menu
{
    public string[] _menuStrings = {
        "Welcome to the Journal Program",
        "Create, display, save, and load journal Entries",
        "1 - Create Journal Entry",
        "2 - Display Journal",
        "3 - Save journal to file",
        "4 - Load journal to file",
        "5 - Quit"

    };

    public int ProcessMenu()
    {
        int userResponse = 0;
        
        do
        {
        Console.Clear();
        foreach(string line in _menuStrings)
        {
            Console.WriteLine(line);
        } 

        Console.Write("Select a choice: ");
        userResponse = int.Parse(Console.ReadLine());

        }
        while (userResponse < 1 || userResponse > 5);

        return userResponse;
    }
}