using UnityEngine;

namespace Beret
{
    public static class BDebug
    {
        public static void DrawCircle(Vector2 center, float radius, float time = 1.0f)
        {
            DrawCircle(center, radius, new Color(1f, 0f, 0f, 1f), time);
        }
        
        public static void DrawCircle(Vector2 center, float radius, Color color, float time = 1.0f)
        {
            int numRays = 36; // Number of rays to approximate the circle (you can adjust this for smoothness)
            float angleIncrement = 360f / numRays;

            Vector2 prevPoint = center + new Vector2(radius, 0f);

            for (int i = 1; i <= numRays; i++)
            {
                float angle = i * angleIncrement;
                Vector2 direction = Quaternion.Euler(0f, 0f, angle) * Vector2.right;
                Vector2 currentPoint = center + direction * radius;
                Debug.DrawLine(prevPoint, currentPoint, color, time);
                prevPoint = currentPoint;
            }
        }
    }
}