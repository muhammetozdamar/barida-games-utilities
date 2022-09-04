using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaridaGames.Utilities.Extensions
{
    public static class EulerAngleExtensions
    {
        public static float ClampAngle(this float axisAngle)
        {
            float temp = axisAngle % 360f;
            if (temp > 180f) temp -= 360f;
            return temp;
        }
        public static Vector3 ClampAngle(this Vector3 eulerAngle)
        {
            return new Vector3(ClampAngle(eulerAngle.x), ClampAngle(eulerAngle.y), ClampAngle(eulerAngle.z));
        }
    }
}