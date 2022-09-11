using BaridaGames.Utilities.Extensions;
using System.Collections.Generic;
using NUnit.Framework;

public class ListExtensionsTest
{
    private const int SHUFFLE_ITERATION_AMOUNT = 500;
    [Test]
    public void ListExtensionsTestSimplePasses()
    {
        List<float> floats = new List<float>();
        floats.Add(69f);

        Assert.AreEqual(69f, floats.GetRandomItem());

        Assert.AreEqual(69f, floats.PopFirst());

        floats.Add(420f);
        Assert.AreEqual(420f, floats.PopLast());

        floats.PushFirst(69f);
        Assert.AreEqual(69f, floats[0]);

        floats.PushLast(420f);
        Assert.AreEqual(420f, floats[floats.Count - 1]);

        floats.Swap(0, 1);
        Assert.AreEqual(420f, floats[0]);
        Assert.AreEqual(69f, floats[floats.Count - 1]);

        bool shuffled = false;
        for (int i = 0; i < SHUFFLE_ITERATION_AMOUNT; i++)
        {
            floats.Shuffle();
            shuffled |= (floats[0] == 69f);
        }
        Assert.IsTrue(shuffled);

        floats.Clear();
        floats.Add(-420);
        floats.Add(10);
        floats.Add(11);
        floats.Add(12);
        floats.Add(13);
        floats.Add(69);

        Assert.AreEqual(-420, floats.Min(), float.Epsilon);
        Assert.AreEqual(69, floats.Max(), float.Epsilon);
    }
}