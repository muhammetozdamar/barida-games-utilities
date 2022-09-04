using BaridaGames.Utilities.Extensions;
using NUnit.Framework;
using UnityEngine;

public class GameObjectExtensionsTest
{
    [Test]
    public void GameObjectExtensionsTestSimplePasses()
    {
        GameObject gameObject = new GameObject("GameObject", typeof(BoxCollider));

        Assert.IsTrue(gameObject.HasComponent<BoxCollider>());
        Assert.IsFalse(gameObject.HasComponent<Rigidbody>());

        Assert.IsNotNull(gameObject.GetOrAddComponent<BoxCollider>());

        Assert.IsNotNull(gameObject.GetOrAddComponent<Rigidbody>());
        Assert.IsTrue(gameObject.HasComponent<Rigidbody>());
    }
}