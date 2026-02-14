public class Word
{
    private bool _isHidden; 
    private string _content;


    public Word(string content)
    {
        _content = content;
        _isHidden = false;
    }

    public string GetWord()
    {
        return _content;
    }

    public bool HideWord()
    {
        if (_isHidden == false)
        {
            _isHidden = true;
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool CheckWordStatus()
    {
        return _isHidden;
    }
}