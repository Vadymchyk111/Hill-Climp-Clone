using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelController : MonoBehaviour
{
    public event Action OnDied;

    [SerializeField] private FuelSliderController fuelSliderController;

    private void Start()
    {
        fuelSliderController.StartFuelCalculation();
    }

    private void OnEnable()
    {
        fuelSliderController.OnFuelIsZero += DoDied;
    }

    private void OnDisable()
    {
        fuelSliderController.OnFuelIsZero -= DoDied;
    }

    public void RecoveryFuel(float starveValue)
    {
        fuelSliderController.RecoveryFuel(starveValue);
    }

    private void DoDied()
    {
        OnDied?.Invoke();
    }
}
