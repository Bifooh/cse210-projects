using System;
using System.Collections.Generic;

public class JournalEntry
{
    public string _currentQuestion;
    public string _usersInput;
    public string _dateText;

    public void CreateJournalEntry()
    {
        _currentQuestion = ReturnRandomQuestion();
        Console.WriteLine(_currentQuestion);
        _usersInput = Console.ReadLine();

        DateTime currentTime = DateTime.Now;
        _dateText = currentTime.ToShortDateString();

    }

    public void PrintEntryInfo()
    {
        Console.WriteLine($"{_dateText}.");
        Console.WriteLine($"{_currentQuestion}");
        Console.WriteLine($": {_usersInput}");
    }

    public string ReturnRandomQuestion() {

    List<string> _questions = new List<string>
    {
        "What was the best part of my day?",
        "What is something new I learned today?",
        "What am  I grateful for?",
        "What challenges did I overcome?",
        "What can I do to make tomorrow better than today? ",
        "Who in my life am I most grateful for, and why?",
        "What is something I love about myself?",
        "What are three small moments that brought me joy this week?",
        "What is a fear that is holding me back?",
        "What is currently causing me stress, and what can I do about it?"
    };
    Random _randomObject = Random.Shared;
    int _randomIndex = _randomObject.Next(_questions.Count);

    return _questions[_randomIndex];
    
    }
}

