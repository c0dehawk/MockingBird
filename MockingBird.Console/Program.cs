// See https://aka.ms/new-console-template for more information
using MockingBird;
using MockingBird.Console;
using Newtonsoft.Json;

while (true)
{
    Console.Clear();
    Console.WriteLine("=== MockingBird Demo ===");
    Console.WriteLine("");
    Console.WriteLine("1. Run Numbers Test");
    Console.WriteLine("2. Run Strings Test");
    Console.WriteLine("3. Run Boolean Test");
    Console.WriteLine("4. Run DateTime Test");
    Console.WriteLine("5. Run Objects Test");
    Console.WriteLine("6. Run Casting Test");
    Console.WriteLine("10. Exit");
    Console.Write("Select an option: ");

    string choice = Console.ReadLine() ?? string.Empty;

    switch (choice)
    {
        case "1":
            RunNumbersTest();
            break;
        case "2":
            RunStringsTest();
            break;
        case "3":
            RunBooleanTest();
            break;
        case "4":
            RunDateTest();
            break;
        case "5":
            RunObjectsTest();
            break;
        case "6":
            RunPersonCastTest();
            break;
        case "10":
            Console.WriteLine("Exiting application. Goodbye!");
            return;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }

    Console.WriteLine("\nPress Enter to return to the menu...");
    Console.ReadLine();
}

static void RunNumbersTest()
{
    Console.Write("How many records do you want to generate? ");
    var input = Console.ReadLine();

    var numberOfRecords = int.TryParse(input, out int n) ? n : 10;

    //Object
    MBObject obj = new MBObject();
    obj.AddProperty(new MBNumberProperty("Int"));
    obj.AddProperty(new MBNumberProperty("IntList", true).SetMinValue(10).SetMaxValue(20));
    obj.AddProperty(new MBNumberProperty("Decimal").SetFormat(MBNumberFormat.Decimal).SetMinValue(1).SetMaxValue(100));
    obj.AddProperty(new MBNumberProperty("DecimalList", true).SetFormat(MBNumberFormat.Decimal).SetMinValue(1).SetMaxValue(1000));
    obj.AddProperty(new MBNumberProperty("Double").SetFormat(MBNumberFormat.Double).SetMinValue(1).SetMaxValue(100));
    obj.AddProperty(new MBNumberProperty("DoubleList", true).SetFormat(MBNumberFormat.Double).SetMinValue(1).SetMaxValue(1000));
    obj.AddProperty(new MBNumberProperty("Float").SetFormat(MBNumberFormat.Float).SetMinValue(1).SetMaxValue(100));
    obj.AddProperty(new MBNumberProperty("FloatList", true).SetFormat(MBNumberFormat.Float).SetMinValue(1).SetMaxValue(1000));
    obj.AddProperty(new MBNumberProperty("Long").SetFormat(MBNumberFormat.Long));
    obj.AddProperty(new MBNumberProperty("LongList", true).SetFormat(MBNumberFormat.Long));

    var sampleRecords = obj.Mock(numberOfRecords);

    Console.Write(JsonConvert.SerializeObject(sampleRecords, Formatting.Indented));
}

static void RunStringsTest()
{
    Console.Write("How many records do you want to generate? ");
    var input = Console.ReadLine();

    var numberOfRecords = int.TryParse(input, out int n) ? n : 10;

    //Object
    MBObject obj = new MBObject();
    obj.AddProperty(new MBStringProperty("String"));
    obj.AddProperty(new MBStringProperty("String_List", true));
    obj.AddProperty(new MBStringProperty("String_Email").SetFormat(MBStringFormat.Email));
    obj.AddProperty(new MBStringProperty("String_Email_List", true).SetFormat(MBStringFormat.Email));
    obj.AddProperty(new MBStringProperty("String_CustomLength").SetLength(5));
    obj.AddProperty(new MBStringProperty("String_CustomLength_List", true).SetLength(5));
    obj.AddProperty(new MBStringProperty("String_FullName").SetFormat(MBStringFormat.FullName));
    obj.AddProperty(new MBStringProperty("String_FullName_List", true).SetFormat(MBStringFormat.FullName));
    obj.AddProperty(new MBStringProperty("String_Phone").SetFormat(MBStringFormat.Phone));
    obj.AddProperty(new MBStringProperty("String_Phone_List", true).SetFormat(MBStringFormat.Phone));
    obj.AddProperty(new MBStringProperty("String_SSN").SetFormat(MBStringFormat.SSN));
    obj.AddProperty(new MBStringProperty("String_SSN_List", true).SetFormat(MBStringFormat.SSN));
    obj.AddProperty(new MBStringProperty("String_AddressLine1").SetFormat(MBStringFormat.AddressLine1));
    obj.AddProperty(new MBStringProperty("String_AddressLine1_List", true).SetFormat(MBStringFormat.AddressLine1));
    obj.AddProperty(new MBStringProperty("String_AddressLine2").SetFormat(MBStringFormat.AddressLine2));
    obj.AddProperty(new MBStringProperty("String_AddressLine2_List", true).SetFormat(MBStringFormat.AddressLine2));
    obj.AddProperty(new MBStringProperty("String_City").SetFormat(MBStringFormat.City));
    obj.AddProperty(new MBStringProperty("String_City_List", true).SetFormat(MBStringFormat.City));
    obj.AddProperty(new MBStringProperty("String_State").SetFormat(MBStringFormat.State));
    obj.AddProperty(new MBStringProperty("String_State_List", true).SetFormat(MBStringFormat.State));
    obj.AddProperty(new MBStringProperty("String_Zip").SetFormat(MBStringFormat.Zip));
    obj.AddProperty(new MBStringProperty("String_Zip_List", true).SetFormat(MBStringFormat.Zip));
    obj.AddProperty(new MBStringProperty("String_Country").SetFormat(MBStringFormat.Country));
    obj.AddProperty(new MBStringProperty("String_Country_List", true).SetFormat(MBStringFormat.Country));
    obj.AddProperty(new MBStringProperty("String_FirstName").SetFormat(MBStringFormat.FirstName));
    obj.AddProperty(new MBStringProperty("String_FirstName_List", true).SetFormat(MBStringFormat.FirstName));
    obj.AddProperty(new MBStringProperty("String_LastName").SetFormat(MBStringFormat.LastName));
    obj.AddProperty(new MBStringProperty("String_LastName_List", true).SetFormat(MBStringFormat.LastName));
    obj.AddProperty(new MBStringProperty("String_Notes").SetLength(1000).SetIncludeSpaces(true).SetIncludeDiacritics(true));
    obj.AddProperty(new MBStringProperty("String_Guid").SetFormat(MBStringFormat.Guid));
    obj.AddProperty(new MBStringProperty("String_Guid_List", true).SetFormat(MBStringFormat.Guid));

    var sampleRecords = obj.Mock(numberOfRecords);

    Console.Write(JsonConvert.SerializeObject(sampleRecords, Formatting.Indented));
}

static void RunBooleanTest()
{
    Console.Write("How many records do you want to generate? ");
    var input = Console.ReadLine();

    var numberOfRecords = int.TryParse(input, out int n) ? n : 10;

    //Object
    MBObject obj = new MBObject();
    obj.AddProperty(new MBBooleanProperty("Bool"));
    obj.AddProperty(new MBBooleanProperty("BoolList", true));
    obj.AddProperty(new MBBooleanProperty("String_Bool_YesNo").SetFormat(MBBooleanFormat.YesNo));
    obj.AddProperty(new MBBooleanProperty("String_Bool_YesNo_List", true).SetFormat(MBBooleanFormat.YesNo));
    obj.AddProperty(new MBBooleanProperty("String_Bool_YN").SetFormat(MBBooleanFormat.YN));
    obj.AddProperty(new MBBooleanProperty("String_Bool_YN_List", true).SetFormat(MBBooleanFormat.YN));
    obj.AddProperty(new MBBooleanProperty("Bit_Bool_OneZero").SetFormat(MBBooleanFormat.OneZero));
    obj.AddProperty(new MBBooleanProperty("Bit_Bool_OneZero_List", true).SetFormat(MBBooleanFormat.OneZero));
    obj.AddProperty(new MBBooleanProperty("String_Bool_TrueFalse").SetFormat(MBBooleanFormat.TrueFalse));
    obj.AddProperty(new MBBooleanProperty("String_Bool_TrueFalse_List", true).SetFormat(MBBooleanFormat.TrueFalse));
    obj.AddProperty(new MBBooleanProperty("String_Bool_70PercentTrue").SetFormat(MBBooleanFormat.TrueFalse).SetTruePercentage(70));
    obj.AddProperty(new MBBooleanProperty("String_Bool_70PercentTrue_List", true).SetFormat(MBBooleanFormat.TrueFalse).SetTruePercentage(70));

    var sampleRecords = obj.Mock(numberOfRecords);

    Console.Write(JsonConvert.SerializeObject(sampleRecords, Formatting.Indented));
}

static void RunDateTest()
{
    Console.Write("How many records do you want to generate? ");
    var input = Console.ReadLine();

    var numberOfRecords = int.TryParse(input, out int n) ? n : 10;

    //Object
    MBObject obj = new MBObject();
    obj.AddProperty(new MBDateTime("Date"));
    obj.AddProperty(new MBDateTime("DateList", true));
    obj.AddProperty(new MBDateTime("Date_FullDateTime").SetFormat(MBDateTimeFormat.FullDateTime));
    obj.AddProperty(new MBDateTime("Date_FullDateTime_List", true).SetFormat(MBDateTimeFormat.FullDateTime));
    obj.AddProperty(new MBDateTime("Date_MonthDay").SetFormat(MBDateTimeFormat.MonthDay));
    obj.AddProperty(new MBDateTime("Date_MonthDay_List", true).SetFormat(MBDateTimeFormat.MonthDay));
    obj.AddProperty(new MBDateTime("Date_ShortDate").SetFormat(MBDateTimeFormat.ShortDate));
    obj.AddProperty(new MBDateTime("Date_ShortDate_List", true).SetFormat(MBDateTimeFormat.ShortDate));
    obj.AddProperty(new MBDateTime("Date_LongDate").SetFormat(MBDateTimeFormat.LongDate));
    obj.AddProperty(new MBDateTime("Date_LongDate_List", true).SetFormat(MBDateTimeFormat.LongDate));
    obj.AddProperty(new MBDateTime("Date_RFC1123").SetFormat(MBDateTimeFormat.RFC1123));
    obj.AddProperty(new MBDateTime("Date_RFC1123_List", true).SetFormat(MBDateTimeFormat.RFC1123));
    obj.AddProperty(new MBDateTime("Date_SortableDateTime").SetFormat(MBDateTimeFormat.SortableDateTime));
    obj.AddProperty(new MBDateTime("Date_SortableDateTime_List", true).SetFormat(MBDateTimeFormat.SortableDateTime));
    obj.AddProperty(new MBDateTime("Date_UniversalSortableDateTime").SetFormat(MBDateTimeFormat.UniversalSortableDateTime));
    obj.AddProperty(new MBDateTime("Date_UniversalSortableDateTime_List", true).SetFormat(MBDateTimeFormat.UniversalSortableDateTime));
    obj.AddProperty(new MBDateTime("Date_CustomRange").SetMinValue(DateTime.Now.AddYears(-1)).SetMaxValue(DateTime.Now).SetFormat(MBDateTimeFormat.ShortDate));
    obj.AddProperty(new MBDateTime("Date_CustomRange_List", true).SetMinValue(DateTime.Now.AddYears(-1)).SetMaxValue(DateTime.Now).SetFormat(MBDateTimeFormat.ShortDate));
    obj.AddProperty(new MBDateTime("Date_CustomStringFormat").SetFormat(MBDateTimeFormat.CustomStringFormat).SetCustomFormatString("yyyy-MM-dd HH:mm:ss"));
    obj.AddProperty(new MBDateTime("Date_CustomStringFormat_List", true).SetFormat(MBDateTimeFormat.CustomStringFormat).SetCustomFormatString("yyyy-MM-dd HH:mm:ss"));


    var sampleRecords = obj.Mock(numberOfRecords);

    Console.Write(JsonConvert.SerializeObject(sampleRecords, Formatting.Indented));
}

static void RunObjectsTest()
{
    Console.Write("How many records do you want to generate? ");
    var input = Console.ReadLine();

    var numberOfRecords = int.TryParse(input, out int n) ? n : 10;

    //Define Sub Object
    MBObject subObj = new MBObject();
    subObj.AddProperty(new MBNumberProperty("Int"));
    subObj.AddProperty(new MBStringProperty("String"));
    subObj.AddProperty(new MBBooleanProperty("Bool"));
    subObj.AddProperty(new MBDateTime("Date").SetFormat(MBDateTimeFormat.ShortDate));
    subObj.AddProperty(new MBStringProperty("String_Email").SetFormat(MBStringFormat.Email));
    subObj.AddProperty(new MBStringProperty("String_FullName").SetFormat(MBStringFormat.FullName));

    MBObject obj = new MBObject();
    obj.AddProperty(new MBNumberProperty("Int"));
    obj.AddProperty(new MBStringProperty("String"));
    obj.AddProperty(new MBBooleanProperty("Bool"));
    obj.AddProperty(new MBDateTime("Date"));
    obj.AddProperty(new MBStringProperty("String_Email").SetFormat(MBStringFormat.Email));
    obj.AddProperty(new MBStringProperty("String_FullName").SetFormat(MBStringFormat.FullName));
    obj.AddProperty(new MBObjectProperty("SubObject", subObj));
    obj.AddProperty(new MBObjectProperty("SubObjectList", subObj, true));

    var sampleRecords = obj.Mock(numberOfRecords);

    Console.Write(JsonConvert.SerializeObject(sampleRecords, Formatting.Indented));
}


static void RunPersonCastTest()
{
    Console.Write("How many records do you want to generate? ");
    var input = Console.ReadLine();

    var numberOfRecords = int.TryParse(input, out int n) ? n : 10;

    MBObject obj = new MBObject();
    obj.AddProperty(new MBStringProperty("Id").SetFormat(MBStringFormat.Guid));
    obj.AddProperty(new MBStringProperty("FirstName").SetFormat(MBStringFormat.FirstName));
    obj.AddProperty(new MBStringProperty("LastName").SetFormat(MBStringFormat.LastName));
    obj.AddProperty(new MBDateTime("DateOfBirth"));
    obj.AddProperty(new MBStringProperty("Email").SetFormat(MBStringFormat.Email));

    var sampleRecords = obj.Mock(numberOfRecords);

// Cast to Person
    List<Person> people = JsonConvert.DeserializeObject<List<Person>>(JsonConvert.SerializeObject(sampleRecords)) ?? new List<Person>();

    Console.Write(JsonConvert.SerializeObject(people, Formatting.Indented));
}