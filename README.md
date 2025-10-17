# MockingBird 

A powerful C# library to mock data for any object or record.  

This project was created originally at BuildIT 2025 by Jason Thomas  

# Getting Started  

## 1. Add A Reference to MockingBird

## 2. Add Using Statement

```
using MockingBird;
```

## 3. Define a MockingBird Object (MBObject) and Add Properties

```
MBObject obj = new MBObject();
obj.AddProperty(new MBStringProperty("Id").SetFormat(MBStringFormat.Guid));
obj.AddProperty(new MBStringProperty("FirstName").SetFormat(MBStringFormat.FirstName));
obj.AddProperty(new MBStringProperty("LastName").SetFormat(MBStringFormat.LastName));
obj.AddProperty(new MBDateTimeProperty("DateOfBirth"));
obj.AddProperty(new MBStringProperty("Email").SetFormat(MBStringFormat.Email));
```

## 4. Call the MBObject's Mock() Method w/ How many records you want

```
var sampleRecords = obj.Mock(numberOfRecords);
```

# Supported Property Types  

## Number (MBNumberProperty)

### Supported Types
- Integer
- Double
- Decimal
- Float
- Long

### Optional Properties
- IsList (Default = false)
- MinValue (Default = 0)
- MaxValue (Default = 1000)
- Format (Default = Integer)
- Decimal Places (Default = 2)

### Usage Samples

```
new MBNumberProperty("Age"); // Basic Integer
new MBNumberProperty("Age").SetMinValue(10).SetMaxValue(20); //Integer between 10-20
new MBNumberProperty("AgeList", true).SetMinValue(10).SetMaxValue(20); //List of Integers between 10-20
new MBNumberProperty("Salary").SetFormat(MBNumberFormat.Decimal).SetMinValue(1).SetMaxValue(100); //Decimal between 1-100
new MBNumberProperty("Decimal").SetFormat(MBNumberFormat.Decimal).Set;
new MBNumberProperty("Long").SetFormat(MBNumberFormat.Long); // Basic Long

```

## String (MBStringProperty)

### Supported Pre-Formatted Strings
- Guid
- AddressLine1
- AddressLine2
- City
- State
- Zip
- Country
- Email
- FirstName
- FullName
- LastName
- SSN
- Sex (M/F)
- JobTitle
- CompanyName
- Phone

### Optional Properties
- IsList (Default = false)
- Length (Default = 20)
- IncludeSpecialCharacters (Default = false)
- IncludeDiacritics (Default = false)
- IncludeNullValues (Default = false)
- IncludeNumeric (Default = false)
- IncludeSpaces (Default = false)
- Format (Default = None)

### Usage Samples 
```
new MBStringProperty("String"); // Basing String
new MBStringProperty("String_List", true); // List of Strings
new MBStringProperty("String_Email").SetFormat(MBStringFormat.Email); //Email
new MBStringProperty("String_CustomLength").SetLength(5);  // String w/ Length of 5
new MBStringProperty("String_SSN").SetFormat(MBStringFormat.SSN); // SSN
new MBStringProperty("String_Notes").SetLength(1000).SetIncludeSpaces(true).SetIncludeDiacritics(true); //String w/ Length of 1000 including spaces and Diacritic chars mixed in
```

## Boolean (MBBooleanProperty)

### Supported Pre-Formatted Strings
- None (bool) (Default)
- TrueFalse (String)
- YesNo (String)
- YN (String)
- OneZero (bit)

### Optional Properties
- IsList (Default = false)
- TruePercentage (Default = 50)
- Format (Default = None)

### Usage Samples 
```
new MBBooleanProperty("Bool"); // Basic Bool
new MBBooleanProperty("BoolList", true); // List of Bool
new MBBooleanProperty("String_Bool_YesNo").SetFormat(MBBooleanFormat.YesNo); // ("Yes" / "No")
```

## DateTime (MBDateTimeProperty)

### Supported Pre-Formatted Strings
- None (DateTime)(Default)
- CustomStringFormat (String)
- FullDateTime (String)
- ShortDate (String)
- LongDate (String)
- MonthDay (String)
- RFC1123 (String) 
- SortableDateTime (String)
- UniversalSortableDateTime (String)
- YearMonth (String)

### Optional Properties
- IsList (Default = false)
- MinValue (Default = -1 Year)
- MaxValue (Default = Now)
- Format (Default = None)
- CustomFormatString

### Usage Samples 
```
new MBDateTimeProperty("Date"); // Basic Date
new MBDateTimeProperty("DateList", true); // List of Dates
new MBDateTimeProperty("Date_ShortDate").SetFormat(MBDateTimeFormat.ShortDate); //Short Date String
new MBDateTimeProperty("Date_CustomRange").SetMinValue(DateTime.Now.AddYears(-3)).SetMaxValue(DateTime.Now.AddYears(2)).SetFormat(MBDateTimeFormat.ShortDate); // Custom Date Range to Short Date String
new MBDateTimeProperty("Date_CustomStringFormat").SetFormat(MBDateTimeFormat.CustomStringFormat).SetCustomFormatString("yyyy-MM-dd HH:mm:ss"); //Custom Formatted Date String
```

## MBObjects (Objects)
You can create complex objects by using an Property Type of "MBObjectProperty" 

### Optional Properties
- IsList (Default = false)

## Usage Samples
```  
//Define Sub Object
MBObject subObj = new MBObject();
subObj.AddProperty(new MBNumberProperty("Int"));
subObj.AddProperty(new MBStringProperty("Name"));
subObj.AddProperty(new MBBooleanProperty("Bool"));
subObj.AddProperty(new MBDateTimeProperty("Date").SetFormat(MBDateTimeFormat.ShortDate));
subObj.AddProperty(new MBStringProperty("String_Email").SetFormat(MBStringFormat.Email));
subObj.AddProperty(new MBStringProperty("String_FullName").SetFormat(MBStringFormat.FullName));  

//Define Main Object
MBObject obj = new MBObject();
obj.AddProperty(new MBNumberProperty("Int"));
obj.AddProperty(new MBStringProperty("String"));
obj.AddProperty(new MBBooleanProperty("Bool"));
obj.AddProperty(new MBDateTimeProperty("Date"));
obj.AddProperty(new MBStringProperty("String_Email").SetFormat(MBStringFormat.Email));
obj.AddProperty(new MBStringProperty("String_FullName").SetFormat(MBStringFormat.FullName));
obj.AddProperty(new MBObjectProperty("SubObject", subObj)); //Single Sub Object
obj.AddProperty(new MBObjectProperty("SubObjectList", subObj, true)); //Sub Object List  

var sampleRecords = obj.Mock(numberOfRecords); //Main Object Mock();
```
## Casting to Your Own Objects

```
List<Person> people = JsonConvert.DeserializeObject<List<Person>>(JsonConvert.SerializeObject(sampleRecords)) ?? new List<Person>();
```

# Contribute

Have a need or idea that is not included in MockingBird?  Contribute!
