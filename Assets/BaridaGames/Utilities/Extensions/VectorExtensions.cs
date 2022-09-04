using UnityEngine;

namespace BaridaGames.Utilities.Extensions
{
    public static class Vector2Extensions
    {
        public static Vector2 SetX(this Vector2 value, float x) => new Vector3(x, value.y);
        public static Vector2 SetY(this Vector2 value, float y) => new Vector2(value.x, y);
        public static Vector2 ModifyX(this Vector2 value, float amount) => SetX(value, value.x + amount);
        public static Vector2 ModifyY(this Vector2 value, float amount) => SetY(value, value.y + amount);
        public static Vector2 ClampX(this Vector2 value, float min, float max) => SetX(value, Mathf.Clamp(value.x, min, max));
        public static Vector2 ClampY(this Vector2 value, float min, float max) => SetY(value, Mathf.Clamp(value.y, min, max));
    }

    public static class Vector2IntExtensions
    {
        public static Vector2Int SetX(this Vector2Int value, int x) => new Vector2Int(x, value.y);
        public static Vector2Int SetY(this Vector2Int value, int y) => new Vector2Int(value.x, y);
        public static Vector2Int ModifyX(this Vector2Int value, int amount) => SetX(value, value.x + amount);
        public static Vector2Int ModifyY(this Vector2Int value, int amount) => SetY(value, value.y + amount);
        public static Vector2Int ClampX(this Vector2Int value, int min, int max) => SetX(value, Mathf.Clamp(value.x, min, max));
        public static Vector2Int ClampY(this Vector2Int value, int min, int max) => SetY(value, Mathf.Clamp(value.y, min, max));
    }

    public static class Vector3Extensions
    {
        public static Vector3 SetX(this Vector3 value, float x) => new Vector3(x, value.y, value.z);
        public static Vector3 SetY(this Vector3 value, float y) => new Vector3(value.x, y, value.z);
        public static Vector3 SetZ(this Vector3 value, float z) => new Vector3(value.x, value.y, z);
        public static Vector3 ModifyX(this Vector3 value, float amount) => SetX(value, value.x + amount);
        public static Vector3 ModifyY(this Vector3 value, float amount) => SetY(value, value.y + amount);
        public static Vector3 ModifyZ(this Vector3 value, float amount) => SetZ(value, value.z + amount);
        public static Vector3 ClampX(this Vector3 value, float min, float max) => SetX(value, Mathf.Clamp(value.x, min, max));
        public static Vector3 ClampY(this Vector3 value, float min, float max) => SetY(value, Mathf.Clamp(value.y, min, max));
        public static Vector3 ClampZ(this Vector3 value, float min, float max) => SetZ(value, Mathf.Clamp(value.z, min, max));

    }

    public static class Vector3IntExtensions
    {
        public static Vector3Int SetX(this Vector3Int value, int x) => new Vector3Int(x, value.y, value.z);
        public static Vector3Int SetY(this Vector3Int value, int y) => new Vector3Int(value.x, y, value.z);
        public static Vector3Int SetZ(this Vector3Int value, int z) => new Vector3Int(value.x, value.y, z);
        public static Vector3Int ModifyX(this Vector3Int value, int amount) => SetX(value, value.x + amount);
        public static Vector3Int ModifyY(this Vector3Int value, int amount) => SetY(value, value.y + amount);
        public static Vector3Int ModifyZ(this Vector3Int value, int amount) => SetZ(value, value.z + amount);
        public static Vector3Int ClampX(this Vector3Int value, int min, int max) => SetX(value, Mathf.Clamp(value.x, min, max));
        public static Vector3Int ClampY(this Vector3Int value, int min, int max) => SetY(value, Mathf.Clamp(value.y, min, max));
        public static Vector3Int ClampZ(this Vector3Int value, int min, int max) => SetZ(value, Mathf.Clamp(value.z, min, max));
    }
}