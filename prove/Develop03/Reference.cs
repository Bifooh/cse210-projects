public class Reference
{
    private string _book;
    private string _chapter;
    private int _initVerse;
    private int _endVerse;

    public Reference(string book, string chapter, int start, int end)
    {
        _book = book;
        _chapter = chapter;
        _initVerse = start;
        _endVerse = end;
    }

    public string GetReference()
    {
        if (_initVerse == _endVerse)
        {
            return $"{_book} {_chapter}:{_initVerse} ";
        }
        else
        {
            return $"{_book} {_chapter}:{_initVerse}-{_endVerse} ";
        }
    }
}