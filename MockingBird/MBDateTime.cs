namespace MockingBird;

public class MBDateTime : IMBProperty
{
    public string Name { get; private set; }
    public bool IsList { get; private set; }
    public DateTime MinValue { get; private set; } = DateTime.Now.AddYears(-1);
    public DateTime MaxValue { get; private set; } = DateTime.Now;
    public string CustomFormatString { get; private set; } = string.Empty;

 public MBDateTimeFormat Format { get; private set; } = MBDateTimeFormat.None;

    public MBDateTime(string name)
    {
        Name = name;
        IsList = false;
    }

    public MBDateTime(string name, bool isList)
    {
        Name = name;
        IsList = isList;
    }

    public MBDateTime SetMinValue(DateTime minValue)
    {
        MinValue = minValue;
        return this;
    }

    public MBDateTime SetMaxValue(DateTime maxValue)
    {
        MaxValue = maxValue;
        return this;
    }

    public MBDateTime SetFormat(MBDateTimeFormat format)
    {
        Format = format;
        return this;
    }

    public MBDateTime SetCustomFormatString(string customFormat)
    {
        CustomFormatString = customFormat;
        return this;
    }
}
