namespace MockingBird;

public class MBDateTimeProperty : IMBProperty
{
    public string Name { get; private set; }
    public bool IsList { get; private set; }
    public DateTime MinValue { get; private set; } = DateTime.Now.AddYears(-1);
    public DateTime MaxValue { get; private set; } = DateTime.Now;
    public string CustomFormatString { get; private set; } = string.Empty;
    public object OverrideValue { get; private set; } = null;

 public MBDateTimeFormat Format { get; private set; } = MBDateTimeFormat.None;

    public MBDateTimeProperty(string name)
    {
        Name = name;
        IsList = false;
    }

    public MBDateTimeProperty(string name, bool isList)
    {
        Name = name;
        IsList = isList;
    }

    public MBDateTimeProperty SetMinValue(DateTime minValue)
    {
        MinValue = minValue;
        return this;
    }

    public MBDateTimeProperty SetMaxValue(DateTime maxValue)
    {
        MaxValue = maxValue;
        return this;
    }

    public MBDateTimeProperty SetFormat(MBDateTimeFormat format)
    {
        Format = format;
        return this;
    }

    public MBDateTimeProperty SetCustomFormatString(string customFormat)
    {
        CustomFormatString = customFormat;
        return this;
    }

    public MBDateTimeProperty SetOverrideValue(object value)
    {
        OverrideValue = value;
        return this;
    }
}
