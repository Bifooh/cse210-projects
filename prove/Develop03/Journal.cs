using System.IO;

public class Journal
{
    public List<JournalEntry> _pages = new List<JournalEntry>();
    string filename = "myJournal.txt";

    public void ShowJournalPage ()
    {
        Console.WriteLine("---------------------");
        Console.WriteLine($"Current temporal entries registered: {_pages.Count}");
        Console.WriteLine("");

        foreach(JournalEntry je in _pages)
        {
            je.PrintEntryInfo();
            Console.WriteLine("");
        }

        Console.WriteLine("");
    }

    public void SaveJournal(){

        using (StreamWriter outputFile = new StreamWriter(filename, true)){

        foreach (JournalEntry jEntry in _pages)
            {
                outputFile.WriteLine($"{jEntry._dateText}|{jEntry._currentQuestion}|{jEntry._usersInput}");
            }

        Console.WriteLine("Journal Pages sucessfully saved!");
        Console.WriteLine("");
        _pages.Clear();
    }
    }

    public void DisplayJournal()
    {
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string date = parts[0];
            string question = parts[1];
            string answer = parts[2];

            Console.WriteLine($"{date}");
            Console.WriteLine($"Q: {question}");
            Console.WriteLine($"A: {answer}");
            Console.WriteLine("");
        }
    }

    public void DisplayByDate(string filteringDate)
    {
        string[] lines = File.ReadAllLines(filename);
        int matches = 0;
        string fDate = "";

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string date = parts[0];
            string question = parts[1];
            string answer = parts[2];

            if (date == filteringDate) {
                
                Console.WriteLine($"Q: {question}");
                Console.WriteLine($"A: {answer}");
                Console.WriteLine("---");

                matches += 1;
                fDate = date;
            }
        }

        if (matches > 1)
        {
            Console.WriteLine($"{matches} matches found.");
        }
        else if (matches == 1)
        {
            Console.WriteLine($"{matches} match found.");
        }
        else
        {
            Console.WriteLine($"No matches found.");
        }

        Console.WriteLine($"For entries on {fDate}");
        Console.WriteLine("");
    }
}