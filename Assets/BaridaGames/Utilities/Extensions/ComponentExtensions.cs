using UnityEngine;

namespace BaridaGames.Utilities.Extensions
{
    public static class ComponentExtensions
    {
        public static T AddComponent<T>(this Component component) where T : Component
        {
            return component.gameObject.AddComponent<T>();
        }

        public static T GetOrAddComponent<T>(this Component component) where T : Component
        {
            T comp = component.GetComponent<T>();
            if (comp != null) return comp;
            return component.AddComponent<T>();
        }

        public static bool HasComponent<T>(this Component component) where T : Component
        {
            return component.GetComponent<T>() != null;
        }
    }
}