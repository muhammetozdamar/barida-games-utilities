using BaridaGames.Utilities.Extensions;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools.Utils;

public class EulerAnglesExtensionsTest
{
    [Test]
    public void EulerAnglesExtensionsTestSimplePasses()
    {
        GameObject gameObject = new GameObject();
        Transform transform = gameObject.transform;
        transform.Rotate(270f, 90f, 0f, Space.World);

        Assert.AreEqual(-90f, transform.eulerAngles.x.ArrangeAngle());
        Assert.AreEqual(90f, transform.eulerAngles.y.ArrangeAngle());
        Assert.AreEqual(0f, transform.eulerAngles.z.ArrangeAngle());

        Assert.That(transform.eulerAngles.ArrangeAngle(), Is.EqualTo(new Vector3(-90f, 90f, 0f)).Using(Vector3EqualityComparer.Instance));

        transform.rotation = Quaternion.identity;
        transform.Rotate(360f, 0f, 0f, Space.World);

        Assert.That(transform.eulerAngles.x.ArrangeAngle(), Is.EqualTo(0f).Using(FloatEqualityComparer.Instance));
        Assert.That(transform.eulerAngles.ArrangeAngle(), Is.EqualTo(new Vector3(0f, 0f, 0f)).Using(Vector3EqualityComparer.Instance));
    }
}
