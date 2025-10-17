namespace MockingBird;

public class MBNumberProperty : IMBProperty
{
    public string Name { get; private set; }
    public bool IsList { get; private set; }
    public int MinValue { get; private set; } = 0;
    public int MaxValue { get; private set; } = 1000;
    public MBNumberFormat Format { get; private set; } = MBNumberFormat.Integer;
    public int DecimalPlaces { get; private set; } = 2;

    public MBNumberProperty(string name)
    {
        Name = name;        
        IsList = false;
    }

     public MBNumberProperty(string name, bool isList)
    {
        Name = name;      
        IsList = isList;
    }

    public MBNumberProperty SetMinValue(int minValue)
    {
        MinValue = minValue;
        return this;
    }

    public MBNumberProperty SetMaxValue(int maxValue)
    {
        MaxValue = maxValue;
        return this;
    }

    public MBNumberProperty SetFormat(MBNumberFormat format)
    {
        Format = format;
        return this;
    }
    public MBNumberProperty SetDecimalPlaces(int decimalPlaces)
    {
        DecimalPlaces = decimalPlaces;
        return this;
    }
}
