using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI.Button
{
    public class CustomButton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
    {
        public event Action<bool> OnClick;

        public void OnPointerUp(PointerEventData eventData)
        {
            OnClick?.Invoke(false);
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            OnClick?.Invoke(true);
        }
    }
}