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
    }
}