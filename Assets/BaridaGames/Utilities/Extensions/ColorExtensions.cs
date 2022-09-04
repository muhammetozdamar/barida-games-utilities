using UnityEngine;

namespace BaridaGames.Utilities.Extensions
{
    public static class ColorExtensions
    {
        public static bool Equals(this Color color, Color other)
        {
            return (Mathf.Approximately(color.r, other.r) &&
                    Mathf.Approximately(color.g, other.g) &&
                    Mathf.Approximately(color.b, other.b) &&
                    Mathf.Approximately(color.a, other.a)
                    );
        }

        public static float EuclideanDistanceOf(this Color color, Color other)
        {
            return Mathf.Sqrt(Mathf.Pow((color.r - other.r), 2) +
                                Mathf.Pow((color.g - other.g), 2) +
                                Mathf.Pow((color.b - other.b), 2) +
                                Mathf.Pow((color.a - other.a), 2));
        }

        public static void SetR(this Color color, float r) => new Color(r, color.g, color.b, color.a);
        public static void SetG(this Color color, float g) => new Color(color.r, g, color.b, color.a);
        public static void SetB(this Color color, float b) => new Color(color.r, color.g, b, color.a);
        public static void SetA(this Color color, float a) => new Color(color.r, color.g, color.b, a);
        public static void SetRGB(this Color color, float r, float g, float b) => new Color(r, g, b, color.a);
    }
}