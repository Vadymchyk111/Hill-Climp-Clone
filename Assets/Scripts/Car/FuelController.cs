using System;
using ScriptableObjects.Events;
using UI;
using UI.Car;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Car
{
    public class FuelController : MonoBehaviour
    {
        public event Action OnDied;

        [SerializeField] private FuelSliderController _fuelSliderController;
        [SerializeField] private ScriptableObjectFloatEvent _addFuelEvent;

        private void Start()
        {
            _fuelSliderController.StartFuelCalculation();
        }

        private void OnEnable()
        {
            _fuelSliderController.OnFuelIsZero += DoDied;
            _addFuelEvent.OnValueChanged += RecoveryFuel;
        }

        private void OnDisable()
        {
            _fuelSliderController.OnFuelIsZero -= DoDied;
            _addFuelEvent.OnValueChanged -= RecoveryFuel;
        }

        private void RecoveryFuel(float starveValue)
        {
            _fuelSliderController.RecoveryFuel(starveValue);
        }

        private void DoDied()
        {
            OnDied?.Invoke();
        }
    }
}