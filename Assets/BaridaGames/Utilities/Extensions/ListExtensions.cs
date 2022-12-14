using System;
using System.Collections.Generic;
using Random = System.Random;
namespace BaridaGames.Utilities.Extensions
{
    public static class ListExtensions
    {
        private static Random rng = new Random();
        public static T GetRandomItem<T>(this IList<T> list)
        {
            return list[rng.Next(list.Count)];
        }

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Swap(list, k, n);
            }
        }

        public static void Swap<T>(this IList<T> list, int i, int j)
        {
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }

        public static T Max<T>(this IList<T> list) where T : IComparable<T>
        {
            int n = list.Count;
            T max = list[0];
            for (int i = 1; i < n; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max;
        }

        public static T Min<T>(this IList<T> list) where T : IComparable<T>
        {
            int n = list.Count;
            T min = list[0];
            for (int i = 1; i < n; i++)
            {
                if (list[i].CompareTo(min) < 0)
                {
                    min = list[i];
                }
            }
            return min;
        }

        public static T PopFirst<T>(this IList<T> list)
        {
            T element = list[0];
            list.RemoveAt(0);
            return element;
        }

        public static T PopLast<T>(this IList<T> list)
        {
            int lastIndex = list.Count - 1;
            T element = list[lastIndex];
            list.RemoveAt(lastIndex);
            return element;
        }

        public static void PushFirst<T>(this IList<T> list, T element)
        {
            list.Insert(0, element);
        }

        public static void PushLast<T>(this IList<T> list, T element)
        {
            list.Add(element);
        }
    }
}