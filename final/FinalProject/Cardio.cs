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
        // calculate calories burnt base on Attributes of the specific type of exercise
        return 0;
    }
}