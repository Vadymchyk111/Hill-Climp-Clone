using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

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
