using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

namespace Beret
{
    public enum BtnEventType
    {
        NONE = 0,
        PRESS,
        RELEASE,
        CLICK,
        TOGGLE
    }

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

        public static UnityEvent GetButton(this RectTransform rect, string element, BtnEventType evtType)
        {
            Transform uiElement = rect.Find(element);
            if (uiElement == null)
            {
                Debug.LogError($"Failed to find {element}");
                return null;
            }

            if (!uiElement.TryGetComponent(out Selectable sel))
            {
                Debug.LogError($"Failed to find a button on {element}");
                return null;
            }

            switch (evtType)
            {
                case BtnEventType.PRESS:
                    break;
                case BtnEventType.RELEASE:
                    break;
                case BtnEventType.CLICK:
                    break;
                case BtnEventType.TOGGLE:
                    break;
                case BtnEventType.NONE:
                default:
                    throw new ArgumentOutOfRangeException(nameof(evtType), evtType, null);
            }
			
			return null;
        }
    }
}