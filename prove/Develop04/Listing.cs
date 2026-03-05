// I added a tracker "_pickedIndexes" so that we don't pick the same index twice.
// Also added an exception for when all questions have been picked already.
public class Listing: Activity
{
    private string _name;
    private string _description;
    private List<string> _questions = new List<string>{"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    private List<int> _pickedIndexes = new List<int>();
    // Constructor
    public Listing(string name, string description): base(name, description)
    {
        _name = name;
        _description = description;
    } 

    public void StartActivity(float time)
    {
        // Displaying spinner for 3 seconds before starting breathing excersise
        Console.WriteLine("Get Ready");
        base.DisplayAnimation01(4);
        Console.WriteLine("List as many responses as you can to the following promt:");
        Console.WriteLine("--- " + GetRandomQuestion() + " ---");
        Console.WriteLine("You may begin in: "); 
        base.Counter(9);
        ReadConsoleForTime(time);
    }

    public string GetRandomQuestion()
    {
        while (true){
        Random re = Random.Shared;
        int randomIndex = re.Next(_questions.Count);

        // Send randomly picked question if:
        // (question haven't been picked before   OR   We already went through all questions in the list)
        if (!_pickedIndexes.Contains(randomIndex) || _pickedIndexes.Count == _questions.Count)
        {
            _pickedIndexes.Add(randomIndex);
            return _questions[randomIndex];
        }
    }
    }

    public void ReadConsoleForTime(float time)
    {
        List<string> listInputs = new List<string>();

        // Setting Time Limit to be in the future
        DateTime timeLimit = DateTime.Now.AddSeconds(time);

        Console.WriteLine("Start typing!! (you may have to press Enter to finish each item)");

        // ask for input in the console for the amount of time designated
        while (DateTime.Now < timeLimit)
        {
            string s = Console.ReadLine();
            listInputs.Add(s);
        }

        Console.WriteLine($"You listed {listInputs.Count} items");
    }
}