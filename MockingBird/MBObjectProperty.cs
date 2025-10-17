using System;

namespace MockingBird;

public class MBObjectProperty : IMBProperty
{
    public string Name { get; private set; }
    public bool IsList { get; private set; }
    public MBObject Definition { get; private set; }

    public MBObjectProperty(string name, MBObject objectType)
    {
        Name = name;
        Definition = objectType ?? throw new ArgumentNullException(nameof(objectType));
        IsList = false;
    }

    public MBObjectProperty(string name, MBObject objectType, bool isList)
    {
        Name = name;
        Definition = objectType ?? throw new ArgumentNullException(nameof(objectType));
        IsList = isList;
    }
}

