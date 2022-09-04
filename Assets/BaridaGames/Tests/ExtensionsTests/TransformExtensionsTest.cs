using BaridaGames.Utilities.Extensions;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.TestTools.Utils;

public class TransformExtensionsTest
{

    [Test]
    public void TransformExtensionsTestSimplePasses()
    {
        GameObject gameObject = new GameObject();
        Transform transform = gameObject.transform;
        transform.position = Vector3.zero;

        Vector3EqualityComparer comparer = Vector3EqualityComparer.Instance;

        transform.SetXPosition(10f);
        Assert.That(transform.position, Is.EqualTo(new Vector3(10f, 0f, 0f)).Using(comparer));

        transform.SetYPosition(10f);
        Assert.That(transform.position, Is.EqualTo(new Vector3(10f, 10f, 0f)).Using(comparer));

        transform.SetZPosition(10f);
        Assert.That(transform.position, Is.EqualTo(new Vector3(10f, 10f, 10f)).Using(comparer));

        transform.ModifyXPosition(-1f);
        Assert.That(transform.position, Is.EqualTo(new Vector3(9f, 10f, 10f)).Using(comparer));

        transform.ModifyYPosition(1f);
        Assert.That(transform.position, Is.EqualTo(new Vector3(9f, 11f, 10f)).Using(comparer));

        transform.ModifyZPosition(0f);
        Assert.That(transform.position, Is.EqualTo(new Vector3(9f, 11f, 10f)).Using(comparer));

        transform.ResetPosition();
        Assert.That(transform.position, Is.EqualTo(new Vector3(0f, 0f, 0f)).Using(comparer));

        transform.Rotate(90f, 270f, 45f);
        transform.ResetRotation();
        Assert.That(transform.rotation, Is.EqualTo(Quaternion.identity).Using(QuaternionEqualityComparer.Instance));

        transform.localScale = new Vector3(2f, 2f, 2f);
        transform.ResetScale();
        Assert.That(transform.localScale, Is.EqualTo(new Vector3(1f, 1f, 1f)).Using(comparer));

        transform.position = new Vector3(1f, 2f, 3f);
        transform.Rotate(90f, 270f, 45f);
        transform.localScale = new Vector3(2f, 2f, 2f);
        transform.Reset();
        Assert.That(transform.position, Is.EqualTo(new Vector3(0f, 0f, 0f)).Using(comparer));
        Assert.That(transform.rotation, Is.EqualTo(Quaternion.identity).Using(QuaternionEqualityComparer.Instance));
        Assert.That(transform.localScale, Is.EqualTo(new Vector3(1f, 1f, 1f)).Using(comparer));

        GameObject child01 = new GameObject();
        child01.transform.SetParent(transform);
        GameObject child02 = new GameObject();
        child02.transform.SetParent(transform);
        GameObject child03 = new GameObject();
        child03.transform.SetParent(transform);

        Assert.AreEqual(3, transform.childCount);
        transform.DestroyChildren(true);
        Assert.AreEqual(0, transform.childCount);
    }
}