public class Education
{
    public string _school;
    public string _titleEarned;

    public string GetDescription()
    {
        return $"{_titleEarned} earned on {_school}";
    }
}