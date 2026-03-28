public class Strengh : Exercise
{
    private int _reps;
    private float _weight;

    public Strengh(int reps, int weight, string name, float caloriesBurnt) : base(name, caloriesBurnt)
    {
        _reps = reps;
        _weight = weight;
        base.SetName(name);
        base.SetCaloriesBurnt(caloriesBurnt);
    }
    public override float GetCaloriesBurnt()
    {
        // calculate calories burnt base on Attributes of the specific type of exercise
        return 0;
    }
}