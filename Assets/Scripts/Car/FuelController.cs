using System;
using UI;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Car
{
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
            SceneManager.LoadScene(0);
            OnDied?.Invoke();
        }
    }
}