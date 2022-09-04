using UnityEngine;

namespace BaridaGames.Utilities.Extensions
{
    public static class GameObjectExtensions
    {
        public static bool HasComponent<T>(this GameObject gameObject) where T : Component
        {
            return gameObject.GetComponent<T>() != null;
        }
        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            T comp = gameObject.GetComponent<T>();
            if (comp != null) return comp;
            return gameObject.AddComponent<T>();
        }
    }
}