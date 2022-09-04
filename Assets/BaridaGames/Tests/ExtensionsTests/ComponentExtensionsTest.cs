using BaridaGames.Utilities.Extensions;
using NUnit.Framework;
using UnityEngine;

public class ComponentExtensionsTest
{
    [Test]
    public void ComponentExtensionsTestSimplePasses()
    {
        GameObject gameObject = new GameObject("GameObject", typeof(BoxCollider), typeof(Rigidbody));
        BoxCollider boxCollider = gameObject.GetComponent<BoxCollider>();
        Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();

        Assert.IsTrue(boxCollider.HasComponent<Rigidbody>());
        Assert.IsTrue(rigidbody.HasComponent<BoxCollider>());

        Assert.IsFalse(boxCollider.HasComponent<SphereCollider>());
        Assert.IsFalse(rigidbody.HasComponent<CapsuleCollider>());

        Assert.NotNull(boxCollider.AddComponent<MeshFilter>());

        Assert.NotNull(rigidbody.GetOrAddComponent<MeshFilter>());
        Assert.NotNull(rigidbody.GetOrAddComponent<MeshRenderer>());

        Assert.IsTrue(boxCollider.HasComponent<MeshRenderer>());
    }
}