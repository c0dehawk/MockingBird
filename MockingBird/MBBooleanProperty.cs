namespace MockingBird;

public class MBBooleanProperty : IMBProperty
{
    public string Name { get; private set; }
    public bool IsList { get; private set; }
    public int TruePercentage { get; private set; } = 50;
    public MBBooleanFormat Format { get; private set; } = MBBooleanFormat.None;

    public MBBooleanProperty(string name)
    {
        Name = name;
        IsList = false;
    }

    public MBBooleanProperty(string name, bool isList)
    {
        Name = name;
        IsList = isList;
    }

    public MBBooleanProperty SetTruePercentage(int percentage)
    {
        if (percentage < 0 || percentage > 100)
            throw new ArgumentOutOfRangeException("Percentage must be between 0 and 100");

        TruePercentage = percentage;
        return this;
    }
    
    public MBBooleanProperty SetFormat(MBBooleanFormat format)
    {
        Format = format;
        return this;
    }
}
