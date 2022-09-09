using UnityEngine;

namespace BaridaGames.Utilities.Extensions
{
    public static class EulerAngleExtensions
    {
        public static float ArrangeAngle(this float axisAngle)
        {
            float temp = axisAngle % 360f;
            if (temp > 180f) temp -= 360f;
            return temp;
        }

        public static float NormalizeAngle(this float axisAngle)
        {
            float temp = axisAngle % 360f;
            if (temp < 0)
                temp += 360f;
            return temp;
        }

        public static Vector3 ArrangeAngle(this Vector3 eulerAngle)
        {
            return new Vector3(ArrangeAngle(eulerAngle.x), ArrangeAngle(eulerAngle.y), ArrangeAngle(eulerAngle.z));
        }
    }
}