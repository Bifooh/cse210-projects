using System.Reflection.Metadata;

public class Motorcycle : Vehicle
{
    private string _handlebarType;

    public Motorcycle (string handlebarType, int wheelNO) : base(wheelNO)
    {
        _handlebarType = handlebarType;
    }

    public string GetDescription()
    {
        return $"This is a motorcycle with {_handlebarType} handle type and {base.GetWheelNumber()} wheels";
    }
}