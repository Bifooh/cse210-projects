public abstract class Goal
{
    private float _weightGoal;
    private float _currentUsersWeight;

    public Goal(float wGoal, float currentW)
    {
        _weightGoal = wGoal;
        _currentUsersWeight = currentW;
    }

    public abstract float CalculateCalorieIntake();

    public float GetWeightGoal()
    {
        return _weightGoal;
    }
    public float GetCurrentWeight()
    {
        return _currentUsersWeight;
    }

    public void SetWeightGoal(float wg)
    {
        _weightGoal = wg;
    }
    public void SetCurrentGoal(float cg)
    {
        _currentUsersWeight = cg;
    }
}