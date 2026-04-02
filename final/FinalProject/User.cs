using System.Data.Common;

public class User
{
    private int _id;
    private string _name;
    private int _age;
    private float _weight;
    private float _height;
    private bool _gender; // True for "male"  && False for "female"
    private Goal _goal;
    private WorkOutArchive _workOutArchive;

    public User()
    {
        _id = 0;
        _name = null;
        _age = 0;
        _weight = 0;
        _height = 0;
        _gender = true;
        _goal = null;
        _workOutArchive = null;
    }

    public User(int id, string name, int age, float weight, float height, bool gender, Goal g, WorkOutArchive wa)
    {
        _id = id;
        _name = name;
        _age = age;
        _weight = weight;
        _height = height;
        _gender = gender;
        _goal = g;
        _workOutArchive = wa;
    }

    public int GetBMR()
    {
        return 0;
    }

    public void AdjustWeight(float w)
    {
        _weight = w;
    }
    public void SetGoal(Goal g)
    {
        _goal = g;
    }

    public int GetId()
    {
        return _id;
    }

    public string GetName()
    {
        return _name;
    }

}