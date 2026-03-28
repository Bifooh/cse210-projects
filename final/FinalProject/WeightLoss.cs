public class WeightLoss : Goal
{
    private float _caloriesToBurn;

    public WeightLoss(float caloriesToBurn, float weightGoal, float currentWeight) : base(weightGoal, currentWeight)
    {
        _caloriesToBurn = caloriesToBurn;
        base.SetWeightGoal(weightGoal);
        base.SetCurrentGoal(currentWeight);
    }
    public override float CalculateCalorieIntake()
    {
        // calculate the right amount of calories to burn/consume every day
        _caloriesToBurn = base.GetCurrentWeight() - base.GetWeightGoal();
        return _caloriesToBurn;
    }
}