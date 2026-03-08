
using System.Security.Cryptography.X509Certificates;

class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter filename: ");
        string fileName = Console.ReadLine();

        List<string> lines = new List<string>();

        foreach (Entry entry in _entries)
        {
            lines.Add(entry.GetFileFormat());
        }

        File.WriteAllLines(fileName, lines);
    }

    public void LoadFromFile()
    {
        Console.Write("Enter filename: ");
        string fileName = Console.ReadLine();

        string[] lines = File.ReadAllLines(fileName);

        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            Entry entry = new Entry();
            entry.SetEntry(parts[0], parts[1], parts[2], parts[3]);

            _entries.Add(entry);
        }

    }

}



