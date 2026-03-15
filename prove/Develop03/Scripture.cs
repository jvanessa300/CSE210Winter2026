using System;
class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] parts = text.Split(" ");

        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = "";

        foreach (Word word in _words)
        {
            scriptureText += word.GetWordString() + " ";
        }

        return $"{_reference.GetReference()} {scriptureText}".Trim();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }

    
}