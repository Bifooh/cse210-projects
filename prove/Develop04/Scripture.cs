using System;
public class Scripture
{
    private List<Word> _wordsList = new List<Word>();
    private Reference _reference;
    
    public Scripture(Reference reference, string verse)
    {
        _reference = reference;
        string[] words = verse.Split(' ');
        foreach (string w in words)
        {
            _wordsList.Add(new Word(w));
        }
    }

    public void PrintScripture()
    {

        Console.Write(_reference.GetReference());

        foreach (Word w in _wordsList)
        {
            if(w.CheckWordStatus() == false)
            {
                Console.Write(w.GetWord() + " ");
            }
            else
            {
                Console.Write("____ ");
            }
        }
    }

    public void HideWordsRandomly()
    {
        int _hiddenWordsCounter = 0;

        while (_hiddenWordsCounter < 4)
        {
            Random _randomObject = Random.Shared;
            int _randomIndex = _randomObject.Next(_wordsList.Count);
            bool _hidden = _wordsList[_randomIndex].HideWord();

            if (_hidden == true)
            {
                _hiddenWordsCounter += 1;
            }
        }

        


    }

    public bool CheckScriptureIsHidden()
    {
        foreach (Word w in _wordsList)
        {
            if(w.CheckWordStatus() == false)
            {
                return false;
            }
        }

        return true;
    }


}