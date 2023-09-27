using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

namespace Beret
{
    public static class UIExtensions
    {
        public static void SetValue<T>(this RectTransform rect, string element, T obj)
        {
            Transform uiElement = rect.Find(element);
            if (uiElement == null)
            {
                Debug.LogError($"Failed to find {element}");
                return;
            }

            switch (obj)
            {
                case Color color:
                    if (uiElement.TryGetComponent(out Image image))
                        image.color = color;

                    if (uiElement.TryGetComponent(out TextMeshProUGUI text))
                        text.color = color;
                    break;
                case string str:
                    if (uiElement.TryGetComponent(out text))
                        text.text = str;
                    break;
                case Sprite sprite:
                    if (uiElement.TryGetComponent(out image))
                        image.sprite = sprite;
                    break;
                default:
                    Debug.LogError($"Unsupported Type: {typeof(T)}");
                    break;
            }
        }
    }
}