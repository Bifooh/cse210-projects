public class MuscleGain : Goal
{
    private float _caloriesToConsume;

    public MuscleGain(float caloriesToConsume, float weightGoal, float currentWeight) : base(weightGoal, currentWeight)
    {
        _caloriesToConsume = caloriesToConsume;
        base.SetWeightGoal(weightGoal);
        base.SetCurrentGoal(currentWeight);
    }
    public override float CalculateCalorieIntake()
    {
        // calculate the right amount of calories to burn/consume every day
        _caloriesToConsume = base.GetCurrentWeight() - base.GetWeightGoal();
        return _caloriesToConsume;
    }
}
