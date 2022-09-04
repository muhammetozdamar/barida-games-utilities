using NUnit.Framework;
using UnityEngine;
using BaridaGames.Utilities.Extensions;

public class ColorExtensionsTest
{
    [Test]
    public void ColorExtensionsTestSimplePasses()
    {
        Color color = new Color(0.25f, 0.5f, 0.75f, 1f);
        Color other = new Color(0.25f, 0.5f, 0.75f, 1f);

        Assert.IsTrue(color.Approximately(other));

        Color otherEuclideanDistance1 = new Color(0.25f, 0.5f, 0.75f, 0f);
        Assert.AreEqual(0f, color.EuclideanDistanceOf(other));
        Assert.AreEqual(1f, color.EuclideanDistanceOf(otherEuclideanDistance1));

        Color otherR1 = new Color(1f, 0.5f, 0.75f, 1f);
        Assert.IsTrue(color.SetR(1f).Approximately(otherR1));

        Color otherG1 = new Color(0.25f, 1f, 0.75f, 1f);
        Assert.IsTrue(color.SetG(1f).Approximately(otherG1));

        Color otherB1 = new Color(0.25f, 0.5f, 1f, 1f);
        Assert.IsTrue(color.SetB(1f).Approximately(otherB1));

        Color otherA0 = new Color(0.25f, 0.5f, 0.75f, 0f);
        Assert.IsTrue(color.SetA(0f).Approximately(otherA0));

        Color otherRGB1 = new Color(1f, 1f, 1f, 1f);
        Assert.IsTrue(color.SetRGB(1f, 1f, 1f).Approximately(otherRGB1));

        Color otherRGB1A0 = new Color(1f, 1f, 1f, 0f);
        Assert.IsFalse(color.SetRGB(1f, 1f, 1f).Approximately(otherRGB1A0));
    }
}