public class LongSimple : Goal
{
    private int _reps;

    public LongSimple (string name, string descript, int points) : base (name, descript, points, "LongSimple")
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

        Console.Write($"{base.GetName()} ({base.GetDescription()}) \x1b[1m-- Long Simple Goal\x1b[0m -- Worked towards: \x1b[1m{_reps}\x1b[0m times");
        Console.WriteLine();
    }

    override public void RecordEvent()
    {
        if (base.GetStatus() == false)
        {
            Console.WriteLine("Select 1 to get points for working towards this goal, or select 2 to mark it as complete and get the points for completetion.");
            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                _reps += 1;
            }
            else if (input == 2)
            {
                base.SetToDone();
            }
            
        }

    }

}