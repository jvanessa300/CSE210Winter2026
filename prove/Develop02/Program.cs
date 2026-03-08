using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Journal journal = new Journal();
        bool done = false;
        int userResponse;
        do
        {
            userResponse = menu.ProcessMenu();
            switch (userResponse)
            {
                case 1:
                    // Create new Journal entry
                    // Add entry to list journal Entries
                    Entry entry = new Entry();
                    entry.CreateNewEntry();
                    journal.AddEntry(entry);

                break;
                case 2:
                    //Display Journal Entries
                    journal.DisplayJournal();
                break;
                case 3:
                    // Save journal to file
                    journal.SaveToFile();
                break;
                case 4:
                    // Load journal from file
                    journal.LoadFromFile();
                break;
                case 5:
                    done = true;
                break;

            }
        }while(!done);
    } 
}