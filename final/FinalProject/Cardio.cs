public class Cardio : Exercise
{
    private int _time;
    private int _intensity;

    public Cardio(int time, int intensity, string name, float caloriesBurnt) : base(name, caloriesBurnt)
    {
        _time = time;
        _intensity = intensity;
        base.SetName(name);
        base.SetCaloriesBurnt(caloriesBurnt);
    }
    public override float GetCaloriesBurnt()
    {
        // Rough estimate: Time (minutes) * Intensity * 1.5 (average baseline multiplier)
        // Example: 30 mins at intensity 5 = 30 * 5 * 1.5 = 225 calories
        float calculatedCalories = _time * _intensity * 1.5f;

        // Save it to the base class attribute so it can be retrieved later
        base.SetCaloriesBurnt(calculatedCalories);

        return calculatedCalories;
    }
}