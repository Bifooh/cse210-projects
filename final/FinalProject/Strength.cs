public class Strength : Exercise
{
    private int _reps;
    private float _weight;

    public Strength(int reps, int weight, string name, float caloriesBurnt) : base(name, caloriesBurnt)
    {
        _reps = reps;
        _weight = weight;
        base.SetName(name);
        base.SetCaloriesBurnt(caloriesBurnt);
    }
    public override float GetCaloriesBurnt()
    {
        // Total Volume = Reps * Weight. 
        // We multiply by 0.05f as a rough estimate of calories burned per pound lifted.
        // Example: 10 reps of 100 lbs = 1000 volume. 1000 * 0.05 = 50 calories.
        float calculatedCalories = _reps * _weight * 0.05f;

        // Save it to the base class attribute
        base.SetCaloriesBurnt(calculatedCalories);

        return calculatedCalories;
    }
}