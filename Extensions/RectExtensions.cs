using UnityEngine;

namespace Beret
{
    public static class RectExtensions
    {
        public static Vector2 GetBottomLeft(this Rect rect)
        {
            return new Vector2(rect.xMin, rect.yMin);
        }

        public static Vector2 GetBottomMiddle(this Rect rect)
        {
            return new Vector2(rect.center.x, rect.yMin);
        }

        public static Vector2 GetBottomRight(this Rect rect)
        {
            return new Vector2(rect.xMax, rect.yMin);
        }

        public static Vector2 GetMiddleLeft(this Rect rect)
        {
            return new Vector2(rect.xMin, rect.center.y);
        }

        public static Vector2 GetMiddleRight(this Rect rect)
        {
            return new Vector2(rect.xMax, rect.center.y);
        }

        public static Vector2 GetTopLeft(this Rect rect)
        {
            return new Vector2(rect.xMin, rect.yMax);
        }

        public static Vector2 GetMiddleTop(this Rect rect)
        {
            return new Vector2(rect.center.x, rect.yMax);
        }

        public static Vector2 GetTopRight(this Rect rect)
        {
            return new Vector2(rect.xMax, rect.yMax);
        }

        public static Rect UnInvert(this Rect rect)
        {
            if (rect.xMin > rect.xMax)
            {
                (rect.xMin, rect.xMax) = (rect.xMax, rect.xMin);
            }

            if (rect.yMin > rect.yMax)
            {
                (rect.yMin, rect.yMax) = (rect.yMax, rect.yMin);
            }

            return rect;
        }
    
        public static void DrawDebugRect(this Rect rect, Color color, float duration = 1f)
        {
            Vector3 bottomLeft = new Vector3(rect.xMin, rect.yMin, 0f);
            Vector3 bottomRight = new Vector3(rect.xMax, rect.yMin, 0f);
            Vector3 topLeft = new Vector3(rect.xMin, rect.yMax, 0f);
            Vector3 topRight = new Vector3(rect.xMax, rect.yMax, 0f);

            Debug.DrawLine(bottomLeft, bottomRight, color, duration);
            Debug.DrawLine(bottomRight, topRight, color, duration);
            Debug.DrawLine(topRight, topLeft, color, duration);
            Debug.DrawLine(topLeft, bottomLeft, color, duration);
        }
    }
}