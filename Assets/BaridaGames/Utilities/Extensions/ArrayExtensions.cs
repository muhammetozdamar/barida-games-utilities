using System;

namespace BaridaGames.Utilities.Extensions
{
    public static class ArrayExtensions
    {
        private static Random rng = new Random();
        public static T GetRandomItem<T>(this T[] array)
        {
            return array[rng.Next(array.Length)];
        }

        public static void Shuffle<T>(this T[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Swap(array, k, n);
            }
        }

        public static void Swap<T>(this T[] array, int i, int j)
        {
            int n = array.Length;
            if (i >= n) throw new ArgumentOutOfRangeException("i", "Parameter index is out of range.");
            if (j >= n) throw new ArgumentOutOfRangeException("j", "Parameter index is out of range.");
            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public static T Max<T>(this T[] array) where T : IComparable<T>
        {
            int n = array.Length;
            T max = array[0];
            for (int i = 1; i < n; i++)
            {
                if (array[i].CompareTo(max) > 0)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public static T Min<T>(this T[] array) where T : IComparable<T>
        {
            int n = array.Length;
            
            T min = array[0];
            for (int i = 1; i < n; i++)
            {
                if (array[i].CompareTo(min) < 0)
                {
                    min = array[i];
                }
            }
            return min;
        }
    }
}