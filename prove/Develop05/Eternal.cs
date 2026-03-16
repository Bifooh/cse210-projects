public class Eternal: Goal
{

    public Eternal (string name, string descrip, int points) : base (name, descrip, points, "Eternal"){}

    override public void DisplayGoal()
    {
        Console.Write($"[ ] {base.GetName()} ({base.GetDescription()}) --\x1b[1m Eternal Goal\x1b[0m");
        Console.WriteLine();
    }

    public override void RecordEvent(){}
}