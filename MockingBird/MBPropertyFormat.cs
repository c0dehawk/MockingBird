namespace MockingBird;

public enum MBStringFormat
{
    None,
    Guid,
    AddressLine1,
    AddressLine2,
    City,
    State,
    Zip,
    Country,
    Email,
    FirstName,
    FullName,
    LastName,
    SSN,
    Sex,
    JobTitle,
    CompanyName,
    Phone
}

public enum MBBooleanFormat
{
    None,
    TrueFalse,
    YesNo,
    YN,
    OneZero
}

public enum MBNumberFormat
{
    Integer,
    Decimal,
    Double,
    Float,
    Long
}

public enum MBDateTimeFormat
{
    None,
    CustomStringFormat,
    FullDateTime,
    ShortDate,
    LongDate,
    MonthDay,
    RFC1123,
    SortableDateTime,
    UniversalSortableDateTime,
    YearMonth
}
