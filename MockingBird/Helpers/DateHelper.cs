namespace MockingBird.Helpers
{
    internal static class DateHelper
    {
        private static readonly Random _random = new Random();

        internal static object GetRandomDateTime(MBDateTimeProperty property)
        {

            var randomDate = GetDateTime(property);

            switch (property.Format)
            {
                case MBDateTimeFormat.None:
                    return randomDate;
                case MBDateTimeFormat.ShortDate:
                    return randomDate.ToShortDateString();
                case MBDateTimeFormat.LongDate:
                    return randomDate.ToLongDateString();
                case MBDateTimeFormat.RFC1123:
                    return randomDate.ToString("R");
                case MBDateTimeFormat.SortableDateTime:
                    return randomDate.ToString("s");
                case MBDateTimeFormat.UniversalSortableDateTime:
                    return randomDate.ToString("u");
                case MBDateTimeFormat.FullDateTime:
                    return randomDate.ToString("F");
                case MBDateTimeFormat.YearMonth:
                    return randomDate.ToString("Y");
                case MBDateTimeFormat.MonthDay:
                    return randomDate.ToString("M");
                case MBDateTimeFormat.CustomStringFormat:
                    try
                    {
                        var test = randomDate.ToString(property.CustomFormatString);
                        return test;
                    }
                    catch (Exception)
                    {
                        return $"The provided custom date format string is invalid for {property.Name}.";              
                    }                 
                default:
                    throw new Exception($"Date Format not recognized for {property.Name}");
            }
        }

        internal static List<object> GetRandomDateTimeList(MBDateTimeProperty property)
        {
            var list = new List<object>();
            var count = _random.Next(2, 10);
            for (int i = 0; i < count; i++)
            {
                list.Add(GetRandomDateTime(property));
            }
            return list;
        }

        internal static DateTime GetDateTime(MBDateTimeProperty property)
        {
            DateTime start = property.MinValue;
            DateTime end = property.MaxValue;

            if (start >= end)
            {
                throw new ArgumentException("MinDate must be earlier than MaxDate.");
            }

            int range = (end - start).Days;
            return start.AddDays(_random.Next(range)).AddHours(_random.Next(0, 24)).AddMinutes(_random.Next(0, 60)).AddSeconds(_random.Next(0, 60));
        }
    }
}
