using BaridaGames.Utilities.Extensions;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools.Utils;

public class VectorExtensionsTest
{
    [Test]
    public void Vector2TestSimplePasses()
    {
        Vector2EqualityComparer comparer = Vector2EqualityComparer.Instance;

        Vector2 testVector = new Vector2(1.2f, 3.4f);

        Assert.That(testVector.SetX(0), Is.EqualTo(new Vector2(0f, 3.4f)).Using(comparer));
        Assert.That(testVector.SetY(0), Is.EqualTo(new Vector2(1.2f, 0f)).Using(comparer));

        Assert.That(testVector.ModifyX(-1f), Is.EqualTo(new Vector2(0.2f, 3.4f)).Using(comparer));
        Assert.That(testVector.ModifyY(1f), Is.EqualTo(new Vector2(1.2f, 4.4f)).Using(comparer));

        Assert.That(testVector.ClampX(0f, 1f), Is.EqualTo(new Vector2(1f, 3.4f)).Using(comparer));
        Assert.That(testVector.ClampY(2f, 4f), Is.EqualTo(new Vector2(1.2f, 3.4f)).Using(comparer));
    }

    [Test]
    public void Vector2IntTestSimplePasses()
    {
        Vector2Int testVector = new Vector2Int(1, 3);

        Assert.AreEqual(new Vector2Int(0, 3), testVector.SetX(0));
        Assert.AreEqual(new Vector2Int(1, -3), testVector.SetY(-3));

        Assert.AreEqual(new Vector2Int(-99, 3), testVector.ModifyX(-100));
        Assert.AreEqual(new Vector2Int(1, 13), testVector.ModifyY(10));

        Assert.AreEqual(new Vector2Int(1, 3), testVector.ClampX(-1, 1));
        Assert.AreEqual(new Vector2Int(1, 1), testVector.ClampY(-1, 1));
    }

    [Test]
    public void Vector3TestSimplePasses()
    {
        Vector3EqualityComparer comparer = Vector3EqualityComparer.Instance;

        Vector3 testVector = new Vector3(1.2f, 3.4f, 5.6f);

        Assert.That(testVector.SetX(0), Is.EqualTo(new Vector3(0f, 3.4f, 5.6f)).Using(comparer));
        Assert.That(testVector.SetY(0), Is.EqualTo(new Vector3(1.2f, 0f, 5.6f)).Using(comparer));
        Assert.That(testVector.SetZ(0), Is.EqualTo(new Vector3(1.2f, 3.4f, 0f)).Using(comparer));

        Assert.That(testVector.ModifyX(-1f), Is.EqualTo(new Vector3(0.2f, 3.4f, 5.6f)).Using(comparer));
        Assert.That(testVector.ModifyY(1f), Is.EqualTo(new Vector3(1.2f, 4.4f, 5.6f)).Using(comparer));
        Assert.That(testVector.ModifyZ(0.1f), Is.EqualTo(new Vector3(1.2f, 3.4f, 5.7f)).Using(comparer));

        Assert.That(testVector.ClampX(0f, 1f), Is.EqualTo(new Vector3(1f, 3.4f, 5.6f)).Using(comparer));
        Assert.That(testVector.ClampY(2f, 4f), Is.EqualTo(new Vector3(1.2f, 3.4f, 5.6f)).Using(comparer));
        Assert.That(testVector.ClampZ(-10f, 0f), Is.EqualTo(new Vector3(1.2f, 3.4f, 0f)).Using(comparer));
    }

    [Test]
    public void Vector3IntTestSimplePasses()
    {
        Vector3Int testVector = new Vector3Int(1, 2, 3);

        Assert.AreEqual(new Vector3Int(0, 2, 3), testVector.SetX(0));
        Assert.AreEqual(new Vector3Int(1, -3, 3), testVector.SetY(-3));
        Assert.AreEqual(new Vector3Int(1, 2, 5), testVector.SetZ(5));

        Assert.AreEqual(new Vector3Int(-99, 2, 3), testVector.ModifyX(-100));
        Assert.AreEqual(new Vector3Int(1, 12, 3), testVector.ModifyY(10));
        Assert.AreEqual(new Vector3Int(1, 2, 3), testVector.ModifyZ(0));


        Assert.AreEqual(new Vector3Int(1, 2, 3), testVector.ClampX(-1, 1));
        Assert.AreEqual(new Vector3Int(1, 1, 3), testVector.ClampY(-1, 1));
        Assert.AreEqual(new Vector3Int(1, 2, 3), testVector.ClampZ(0, 10));
    }
}