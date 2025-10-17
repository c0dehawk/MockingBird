using System.Dynamic;
using MockingBird.Helpers;

namespace MockingBird
{
    internal static class MBDataFactory
    {
        private static readonly Random _random = new Random();

        internal static List<ExpandoObject> GetData(MBObject mbObject, int count)
        {
            var result = new List<ExpandoObject>();

            for (int i = 0; i < count; i++)
            {
                dynamic obj = new ExpandoObject();
                var dict = (IDictionary<string, object>)obj;

                foreach (var property in mbObject.Properties)
                {
                    switch (property)
                    {
                        case MBNumberProperty numberProperty:
                            if (numberProperty.IsList)
                            {
                                dict[numberProperty.Name] = NumberHelper.GetRandomNumberList(numberProperty);
                            }
                            else
                            {
                                dict[numberProperty.Name] = NumberHelper.GetRandomNumber(numberProperty);
                            }
                            break;
                        case MBStringProperty stringProperty:
                            if (stringProperty.IsList)
                            {
                                dict[stringProperty.Name] = StringHelper.GetRandomStringList(stringProperty);
                            }
                            else
                            {
                                dict[stringProperty.Name] = StringHelper.GetRandomString(stringProperty);
                            }
                            break;
                        case MBBooleanProperty boolProperty:
                            if (boolProperty.IsList)
                            {
                                dict[boolProperty.Name] = BooleanHelper.GetRandomBoolList(boolProperty);
                            }
                            else
                            {
                                dict[boolProperty.Name] = BooleanHelper.GetRandomBool(boolProperty);
                            }
                            break;
                        case MBDateTimeProperty dateTimeProperty:
                            if (dateTimeProperty.IsList)
                            {
                                dict[dateTimeProperty.Name] = DateHelper.GetRandomDateTimeList(dateTimeProperty);
                            }
                            else
                            {
                                dict[dateTimeProperty.Name] = DateHelper.GetRandomDateTime(dateTimeProperty);
                            }
                            break;
                        case MBObjectProperty mbObjProperty:
                            if (mbObjProperty.IsList)
                            {
                                dict[mbObjProperty.Name] = GetData(mbObjProperty.Definition, 3);
                            }
                            else
                            {
                                dict[mbObjProperty.Name] = GetData(mbObjProperty.Definition, 1).First();
                            }
                            break;
                        default:
                            throw new Exception($"Not a supported Data Type for '{property.Name}'");
                    }
                }

                result.Add(obj);
            }

            return result;
        }
    }
}
