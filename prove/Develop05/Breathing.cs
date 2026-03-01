// using Math;

public class Breathing: Activity
{
    private string _name;
    private string _description;
    private int _timeIn;
    private int _timeOut;

    // Constructor
    public Breathing(string name, string description): base(name, description)
    {
        _name = name;
        _description = description;
        _timeIn = 3; //Default time for breathing in 4s
        _timeOut = 5; //Default time for breathing out 6s
    } 

    public void StartActivity(float time)
    {
        // Calculating how many full breathing exercises can be fit in the time (seconds)
        float full_breathing = time / 10;
        // Rounding UP calculation to the next integer
        int abe = (int)Math.Ceiling(full_breathing);
        // Displaying spinner for 5 seconds before starting breathing excersise
        Console.WriteLine("Get Ready");
        base.DisplayAnimation01(4);

        // Lopping through the "Amount of Breathing Excersices" (abe). Assingning i = abe.
        for (int i = abe; i > 0; i--)
        {
            Console.WriteLine("Breathe in...");
            base.Counter(_timeIn);
            Console.WriteLine("Breathe out...");
            base.Counter(_timeOut);
        }

    }


}