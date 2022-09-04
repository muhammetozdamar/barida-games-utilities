using UnityEngine;

namespace BaridaGames.Utilities.Extensions
{
    public static class TransformExtensions
    {
        public static void SetXPosition(this Transform transform, float x)
        {
            transform.position = transform.position.SetX(x);
        }
        public static void SetYPosition(this Transform transform, float y)
        {
            transform.position = transform.position.SetY(y);
        }
        public static void SetZPosition(this Transform transform, float z)
        {
            transform.position = transform.position.SetZ(z);
        }
        public static void ModifyXPosition(this Transform transform, float amount)
        {
            transform.position = transform.position.ModifyX(amount);
        }
        public static void ModifyYPosition(this Transform transform, float amount)
        {
            transform.position = transform.position.ModifyY(amount);
        }
        public static void ModifyZPosition(this Transform transform, float amount)
        {
            transform.position = transform.position.ModifyZ(amount);
        }
        public static void DestroyChildren(this Transform transform)
        {
            int childCount = transform.childCount;
            for (int i = 0; i < childCount; i++)
            {
                Object.Destroy(transform.GetChild(0).gameObject);
            }
        }
    }
}