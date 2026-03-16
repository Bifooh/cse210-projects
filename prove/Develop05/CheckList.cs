using System.ComponentModel;
using System.Net.Mail;

public class CheckList: Goal
{
    private int _reps;
    private int _repsGoal;
    private int _bonusPoints;

    public CheckList(string name, string descrip, int points, int reps, int bonusP) : base (name, descrip, points, "CheckList")
    {
        _repsGoal = reps;
        _bonusPoints = bonusP;
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

        Console.Write($"{base.GetName()} ({base.GetDescription()}) --\x1b[1m CheckList Goal\x1b[0m");
        Console.Write($" -- Completed: \x1b[1m{_reps}/{_repsGoal}\x1b[0m");
        Console.WriteLine();
    }

    override public void RecordEvent()
    {
        if (_reps < _repsGoal)
        {
            _reps += 1;
        }
        if (_reps == _repsGoal)
        {
            base.SetToDone();
        }
    }

    override public string GetExtraData()
    {
        return $"{_reps},{_repsGoal},{_bonusPoints}";
    }

    override public int GetBonusPoints()
    {
        return _bonusPoints;
    }
}