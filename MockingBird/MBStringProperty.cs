namespace MockingBird;

public class MBStringProperty : IMBProperty
{
    public string Name { get; private set; }
    public bool IsList { get; private set; } = false;
    public int Length { get; private set; } = 20;
    public bool IncludeSpecialCharacters { get; private set; } = false;
    public bool IncludeDiacritics { get; private set; } = false;
    public bool IncludeNullValues { get; private set; } = false;
    public bool IncludeNumeric { get; private set; } = false;
    public bool IncludeSpaces { get; private set; } = false;
    public MBStringFormat Format { get; private set; } = MBStringFormat.None;

    public MBStringProperty(string name)
    {
        Name = name;
    }

    public MBStringProperty(string name, bool isList)
    {
        Name = name;
        IsList = isList;
    }

    public MBStringProperty SetLength(int length)
    {
        Length = length;
        return this;
    }

    public MBStringProperty SetFormat(MBStringFormat value)
    {
        Format = value;
        return this;
    }
    public MBStringProperty SetIncludeSpecialCharacters(bool include)
    {
        IncludeSpecialCharacters = include;
        return this;
    }

    public MBStringProperty SetIncludeDiacritics(bool include)
    {
        IncludeDiacritics = include;
        return this;
    }

    public MBStringProperty SetIncludeNullValues(bool include)
    {
        IncludeNullValues = include;
        return this;
    }

    public MBStringProperty SetIncludeNumeric(bool include)
    {
        IncludeNumeric = include;
        return this;
    }
    public MBStringProperty SetIncludeSpaces(bool include)
    {
        IncludeSpaces = include;
        return this;
    }
}
