
class Reference
{
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _lastVerse;

    public Reference(string book, int chapter, int FV, int LV)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = FV;
        _lastVerse = LV;
    }

    public Reference(string book, int chapter, int FV)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = FV;
        _lastVerse = 0;
    }

    public string GetReference()
    {
        if (_lastVerse != 0)
        return $"{_book} {_chapter}:{_firstVerse}-{_lastVerse}";

        else
        return $"{_book} {_chapter}:{_firstVerse}";
    }
    
}