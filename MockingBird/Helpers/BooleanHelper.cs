using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockingBird.Helpers
{
    internal static class BooleanHelper
    {
        private static readonly Random _random = new Random();

        internal static object GetRandomBool(MBBooleanProperty property)
        {
            var result = IsSuccessful(property.TruePercentage);

            switch (property.Format)
            {
                case MBBooleanFormat.TrueFalse:
                    return result ? "True" : "False";
                case MBBooleanFormat.YesNo:
                    return result ? "Yes" : "No";
                case MBBooleanFormat.YN:
                    return result ? "Y" : "N";
                case MBBooleanFormat.OneZero:
                    return result ? 1 : 0;
                case MBBooleanFormat.None:
                default:
                    return result;
            }
        }

        internal static List<object> GetRandomBoolList(MBBooleanProperty property)
        {
            var list = new List<object>();
            int count = _random.Next(2, 10);
            for (int i = 0; i < count; i++)
            {
                list.Add(GetRandomBool(property));
            }
            return list;
        }

        internal static bool IsSuccessful(int percentage)
        {
            if (percentage < 0 || percentage > 100)
                throw new ArgumentOutOfRangeException(nameof(percentage), "Percentage must be between 0 and 100.");

            return _random.Next(0, 100) < percentage;
        }

    }
}
