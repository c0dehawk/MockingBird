using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockingBird.Helpers
{
    internal static class NumberHelper
    {
        private static readonly Random _random = new Random();

        internal static object GetRandomNumber(MBNumberProperty property)
        {

            switch (property.Format)
            {
                case MBNumberFormat.Integer:
                    return GetRandomInt(property.MinValue, property.MaxValue);
                case MBNumberFormat.Decimal:
                    return Math.Round(GetRandomDecimal(property.MinValue, property.MaxValue), property.DecimalPlaces);
                case MBNumberFormat.Double:
                    return Math.Round(GetRandomDouble(property.MinValue, property.MaxValue), property.DecimalPlaces);
                case MBNumberFormat.Float:
                    return Math.Round(GetRandomFloat(property.MinValue, property.MaxValue), property.DecimalPlaces);
                case MBNumberFormat.Long:
                    return GetRandomLong();                   
                default:
                    throw new ArgumentOutOfRangeException();
            }    
        }

        internal static List<object> GetRandomNumberList(MBNumberProperty property)
        {
            var list = new List<object>();
            int count = _random.Next(2, 20);
            for (int i = 0; i < 4; i++)
            {
                list.Add(GetRandomNumber(property));
            }
            return list;
        }

        internal static int GetRandomInt(int min = 0, int max = 1000)
        {
            if (min >= max)
            {
                throw new ArgumentException("Min must be less than Max.");
            }
            return _random.Next(min, max);
        }

        internal static double GetRandomDouble(double min = 0, double max = 1000)
        {
            if (min >= max)
            {
                throw new ArgumentException("Min must be less than Max.");
            }
            return _random.NextDouble() * (max - min) + min;
        }

        internal static float GetRandomFloat(float min = 0, float max = 1000)
        {
            if (min >= max)
            {
                throw new ArgumentException("Min must be less than Max.");
            }
            var range = max - min;
            var sample = _random.NextDouble();
            var scaled = (float)(sample * range);
            return scaled + min;
        }

        internal static long GetRandomLong()
        {
            byte[] buffer = new byte[8];
            _random.NextBytes(buffer);
            return Math.Abs(BitConverter.ToInt64(buffer, 0));
        }
        
       internal static decimal GetRandomDecimal(decimal min = 0, decimal max = 1000)
        {
            if (min >= max)
            {
                throw new ArgumentException("Min must be less than Max.");
            }
            var next = (decimal)_random.NextDouble();
            return min + (next * (max - min));
        }               
    }
}
