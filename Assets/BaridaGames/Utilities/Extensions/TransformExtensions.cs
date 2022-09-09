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
        public static void SetLocalXPosition(this Transform transform, float x)
        {
            transform.localPosition = transform.localPosition.SetX(x);
        }
        public static void SetLocalYPosition(this Transform transform, float y)
        {
            transform.localPosition = transform.localPosition.SetY(y);
        }
        public static void SetLocalZPosition(this Transform transform, float z)
        {
            transform.localPosition = transform.localPosition.SetZ(z);
        }
        public static void ModifyLocalXPosition(this Transform transform, float amount)
        {
            transform.localPosition = transform.localPosition.ModifyX(amount);
        }
        public static void ModifyLocalYPosition(this Transform transform, float amount)
        {
            transform.localPosition = transform.localPosition.ModifyY(amount);
        }
        public static void ModifyLocalZPosition(this Transform transform, float amount)
        {
            transform.localPosition = transform.localPosition.ModifyZ(amount);
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

        public static void ResetLocalPosition(this Transform transform)
        {
            transform.localPosition = new Vector3(0, 0, 0);
        }

        public static void ResetRotation(this Transform transform)
        {
            transform.rotation = new Quaternion();
        }
        public static void ResetLocalRotation(this Transform transform)
        {
            transform.localRotation = new Quaternion();
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

        public static void ResetLocal(this Transform transform)
        {
            ResetLocalPosition(transform);
            ResetLocalRotation(transform);
            ResetScale(transform);
        }

        public static Transform GetLastChild(this Transform transform)
        {
            int childCount = transform.childCount;
            if (childCount == 0) return null;
            return transform.GetChild(childCount - 1);
        }
    }
}