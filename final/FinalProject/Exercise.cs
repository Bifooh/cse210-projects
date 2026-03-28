public abstract class Exercise
{
    private string _name;
    private float _caloriesBurnt;

    public Exercise(string n, float caloriesBurnt)
    {
        _name = n;
        _caloriesBurnt = caloriesBurnt;
    }
    public abstract float GetCaloriesBurnt();
    public void SetName(string n) { _name = n; }
    public void SetCaloriesBurnt(float c) { _caloriesBurnt = c; }
}