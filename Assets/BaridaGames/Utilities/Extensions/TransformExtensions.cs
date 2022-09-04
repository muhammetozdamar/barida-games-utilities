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
        public static void DestroyChildren(this Transform transform, bool immediate = false)
        {
            int childCount = transform.childCount;
            for (int i = 0; i < childCount; i++)
            {
                if (immediate)
                    Object.DestroyImmediate(transform.GetChild(0).gameObject);
                else
                    Object.Destroy(transform.GetChild(0).gameObject);
            }
        }

        public static void ResetPosition(this Transform transform)
        {
            transform.position = new Vector3(0, 0, 0);
        }

        public static void ResetRotation(this Transform transform)
        {
            transform.rotation = new Quaternion();
        }

        public static void ResetScale(this Transform transform)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        public static void Reset(this Transform transform)
        {
            ResetPosition(transform);
            ResetRotation(transform);
            ResetScale(transform);
        }
    }
}