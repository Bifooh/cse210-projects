public abstract class Goal
{
    private string _name;
    private string _description;
    private int _pointsValue;
    private bool _acomplished;
    private string _type;

    public Goal(string n, string d, int p, string t)
    {
        _name = n;
        _description = d;
        _pointsValue = p;
        _acomplished = false;
        _type = t;
    }

    public int GetPoints()
    {
        return _pointsValue;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public bool GetStatus()
    {
        return _acomplished;
    }
    public string GetTypeOfGoal()
    {
        return _type;
    }
    public void SetToDone()
    {
        _acomplished = true;
    }
    
    abstract public void DisplayGoal();

    abstract public void RecordEvent();
    
    // This is used to get the extra data from the checklist goal.
    virtual public string GetExtraData()
    {
        return "0,0,0";
    }

    virtual public int GetBonusPoints()
    {
        return 0;
    }

}