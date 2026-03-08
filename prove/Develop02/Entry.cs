
using System.IO.Compression;

class Entry
{
    string _date;
    string _prompt;
    string _response;

    string _mood;

    public List<string> _listOfPrompt = new List<string>
    {
      "How was your day?", "What are you grateful for today?", "What did you eat for breakfast?", 
      "What are your goals for this week?", "What was the best part of your day?"

    };

    Random random = new Random();

    public void CreateNewEntry()
    {
        _date = "Today's Date: ";

        _prompt = _listOfPrompt[random.Next(_listOfPrompt.Count())];

        Console.WriteLine($"{_prompt}: ");
        _response = Console.ReadLine();

        Console.Write("How was your mood today? ");
        _mood = Console.ReadLine();

    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Today's Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Responce: {_response}");
        Console.WriteLine($"Mood: {_mood}");
    }

    public string GetFileFormat()
    {
        return $"{_date}|{_prompt}|{_response}|{_mood}";
    }

    public void SetEntry(string date, string prompt, string response, string mood)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
        _mood = mood;
    }
}