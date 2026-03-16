
public class Simple : Goal
{

    public Simple (string name, string descript, int points) : base (name, descript, points, "Simple")
    {
        
    }

    override public void DisplayGoal()
    {
        if (base.GetStatus())
        {
            Console.Write("[X] ");
        }
        else
        {
            Console.Write("[ ] ");
        }

        Console.Write($"{base.GetName()} ({base.GetDescription()}) --\x1b[1m Simple Goal\x1b[0m");
        Console.WriteLine();
    }

    override public void RecordEvent()
    {
        if (base.GetStatus() == false)
        {
            base.SetToDone();
        }

    }
}