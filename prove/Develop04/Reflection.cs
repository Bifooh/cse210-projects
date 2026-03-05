using System.Diagnostics.CodeAnalysis;
// I added a tracker "_pickedIndexes" so that we don't pick the same index twice.
// Also added an exception for when all questions have been picked already.
public class Reflection: Activity
{
    private string _name;
    private string _description;
    private int _secondsToReflect = 10;
    private List<string> _prompts = new List<string>(){"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    private List<string> _questions = new List<string>(){"Why was this experience meaningful to you?", "How did you get started?", "Have you ever done anything like this before?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
    // Keeping track of the questions already asked, so that they don't repeat in the reflection time.
    private List<int> _pickedIndexes = new List<int>();
        // Constructor
    public Reflection(string name, string description): base(name, description)
    {
        _name = name;
        _description = description;
    } 

    public void StartActivity(float time)
    {
        string promt = GetRandomPromt();

        // Displaying spinner for 5 seconds before starting breathing excersise
        Console.WriteLine("Get Ready");
        base.DisplayAnimation01(4);
        Console.WriteLine();
        Console.WriteLine("Consider the following promt:");
        Console.WriteLine();
        Console.WriteLine($"--- {promt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Now Ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine("You may begin in: "); base.Counter(8);

        Console.Clear();
        Console.WriteLine($"Prompt: {promt}");
        Console.WriteLine();
        DisplayMultipleQuestions(time);

    }
    public string GetRandomPromt()
    {
        Random re = Random.Shared;
        int randomIndex = re.Next(_prompts.Count);

        return _prompts[randomIndex];
    }

    public string ReturnNewQuestion()
    {
        while (true){
        Random re = Random.Shared;
        int randomIndex = re.Next(_prompts.Count);

        // Send randomly picked promt if:
        // (question haven't been picked before   OR   We already went through all promts in the list)
        if (!_pickedIndexes.Contains(randomIndex) || _pickedIndexes.Count == _prompts.Count)
        {
            _pickedIndexes.Add(randomIndex);
            return _questions[randomIndex];
        }
    }    
    }

    public void DisplayMultipleQuestions(float time)
    {
        // Calculate amount of sessions (times we ask a new cuention and start the timer)
        float sessions = time / _secondsToReflect;
        // Round calculation to an integer
        int amountOfSessions = (int)Math.Ceiling(sessions);

        for (int i = amountOfSessions; i > 0; i--)
        {
            // Display a new random  question
            Console.WriteLine(ReturnNewQuestion());
            // Pinner for the preset amount of refletion time.
            base.DisplayAnimation03(_secondsToReflect);
        }
    }

}