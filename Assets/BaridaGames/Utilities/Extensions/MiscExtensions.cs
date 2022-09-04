using System;

namespace BaridaGames.Utilities.Extensions
{
    public static class MiscExtensions
    {
        public static bool IsBetween<T>(this T value, T lowerBound, T upperBound, bool lowerExclusive = false, bool upperExclusive = false) where T : IComparable<T>
        {
            bool lowerResult = lowerExclusive ? value.CompareTo(lowerBound) > 0 : value.CompareTo(lowerBound) >= 0;
            bool upperResult = upperExclusive ? value.CompareTo(upperBound) < 0 : value.CompareTo(upperBound) <= 0;
            return lowerResult && upperResult;
        }

        public static float LinearRemap(this float value,
                                     float valueRangeMin, float valueRangeMax,
                                     float newRangeMin, float newRangeMax)
        {
            return (value - valueRangeMin) / (valueRangeMax - valueRangeMin) * (newRangeMax - newRangeMin) + newRangeMin;
        }

        public static int LinearRemap(this int value,
                                     int valueRangeMin, int valueRangeMax,
                                     int newRangeMin, int newRangeMax)
        {
            return (value - valueRangeMin) / (valueRangeMax - valueRangeMin) * (newRangeMax - newRangeMin) + newRangeMin;
        }

        public static double LinearRemap(this double value,
                                     double valueRangeMin, double valueRangeMax,
                                     double newRangeMin, double newRangeMax)
        {
            return (value - valueRangeMin) / (valueRangeMax - valueRangeMin) * (newRangeMax - newRangeMin) + newRangeMin;
        }
    }
}