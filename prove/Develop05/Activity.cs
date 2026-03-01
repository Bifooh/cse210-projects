public class Activity
{
    private string _name;
    private string _description;


    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public Activity()
    {
        _name = "";
        _description = "";
    }

    public int DisplayWelcomeMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity!!");
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.WriteLine($"How long 'in seconds' would you like your session to be?");
        int time = int.Parse(Console.ReadLine());
        return time;
    }

    public void DisplayEndMessage(int time)
    {
        Console.WriteLine("Well done!!");
        DisplayAnimation01(3);

        Console.WriteLine($"You have completed another {time} seconds of the {_name} Activity.");
        DisplayAnimation02(3);
    }

    public void DisplayAnimation01(int seconds)
    {
        for (int i = seconds; i > 0 ; i--)
        {
            Console.Write(".");
            Thread.Sleep(333);
            Console.Write("\b \b");
            Console.Write("o");
            Thread.Sleep(333);
            Console.Write("\b \b");
            Console.Write("O");
            Thread.Sleep(333);
            Console.Write("\b \b");
        }
    }
    public void DisplayAnimation02(int seconds)
    {
        for (int i = seconds; i > 0 ; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }
        public void DisplayAnimation03(int seconds)
    {
        for (int i = seconds; i > 0 ; i--)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

        public void Counter(int timeInSeconds){

        DateTime futureTime = DateTime.Now.AddSeconds(timeInSeconds);
        int currentSecond = timeInSeconds;

        while (DateTime.Now < futureTime)
        {
            Console.Write($"{currentSecond}");
            // Wait 1 second
            Thread.Sleep(1000);
            currentSecond -= 1;
            Console.Write("\b \b");
        }
    }
}