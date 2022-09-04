using BaridaGames.Utilities.Extensions;
using NUnit.Framework;


public class MiscExtensionsTest
{
    [Test]
    public void MiscExtensionsTestSimplePasses()
    {
        float value = 5f;
        float lowerBound = 0f;
        float lowerBoundExclusive = 5f;
        float upperBound = 10f;
        float upperBoundExclusive = 5f;

        Assert.IsTrue(value.IsBetween(lowerBound, upperBound, false, false));
        Assert.IsTrue(value.IsBetween(lowerBound, upperBound, true, true));

        Assert.IsTrue(value.IsBetween(lowerBoundExclusive, upperBoundExclusive, false, false));
        Assert.IsFalse(value.IsBetween(lowerBoundExclusive, upperBoundExclusive, true, true));

        Assert.IsFalse(value.IsBetween(lowerBoundExclusive, upperBound, true, false));
        Assert.IsFalse(value.IsBetween(lowerBound, upperBoundExclusive, false, true));

        float floatValue = 0.5f;
        float floatValueRangeMin = 0f;
        float floatValueRangeMax = 1f;
        float floatNewRangeMin = 0f;
        float floatNewRangeMax = 10f;

        Assert.AreEqual(5f, floatValue.LinearRemap(floatValueRangeMin, floatValueRangeMax, floatNewRangeMin, floatNewRangeMax));

        int intValue = 5;
        int intValueRangeMin = 5;
        int intValueRangeMax = 10;
        int intNewRangeMin = 10;
        int intNewRangeMax = 20;

        Assert.AreEqual(10, intValue.LinearRemap(intValueRangeMin, intValueRangeMax, intNewRangeMin, intNewRangeMax));

        double doubleValue = 0.5d;
        double doubleValueRangeMin = 0d;
        double doubleValueRangeMax = 1d;
        double doubleNewRangeMin = 0d;
        double doubleNewRangeMax = 10d;

        Assert.AreEqual(5d, doubleValue.LinearRemap(doubleValueRangeMin, doubleValueRangeMax, doubleNewRangeMin, doubleNewRangeMax));
    }
}