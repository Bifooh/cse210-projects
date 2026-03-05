
public class Resume
{
    public string _name;
    public List<Job> _experience = new List<Job>();
    public List<Education> _education = new List<Education>();

    public void DisplayFullResume()
    {
        Console.WriteLine($"Resume for {_name}");

        foreach(Job job in _experience)
        {
            string desc = job.GetDescription();
            Console.WriteLine($"    {desc}");

        }

        foreach(Education edu in _education)
        {
            string des = edu.GetDescription();
            Console.WriteLine($"    {des}");

        }

        Console.WriteLine("");
    }
}