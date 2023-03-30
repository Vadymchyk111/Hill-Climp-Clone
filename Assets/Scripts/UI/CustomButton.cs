using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CustomButton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public event Action<bool> OnClick;

    [SerializeField] private Image _image;
    [SerializeField] private Sprite _activePedal;
    [SerializeField] private Sprite _deactivePedal;

    public void OnPointerUp(PointerEventData eventData)
    {
        SetActivePedal(false);
        OnClick?.Invoke(false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        SetActivePedal(true);
        OnClick?.Invoke(true);
    }

    private void SetActivePedal(bool isActive)
    {
        _image.sprite = isActive ? _activePedal : _deactivePedal;
    }
}
