using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class FuelSliderController : MonoBehaviour
    {
        public event Action OnFuelIsZero;

        [SerializeField] private Slider _slider;
        [SerializeField] private float _fuelUpdateTickInSeconds = 0.1f;
        [SerializeField] private float _fuelDectreaseValueInTick = 0.01f;

        private Coroutine _fuelCoroutine;
        private WaitForSeconds _fuelUpdateTickInSecondsDelay;

        private void Awake()
        {
            _fuelUpdateTickInSecondsDelay = new WaitForSeconds(_fuelUpdateTickInSeconds);
        }

        public void RecoveryFuel(float value)
        {
            _slider.value += value;
        }

        public void StartFuelCalculation()
        {
            StopFuelCalculation();

            _fuelCoroutine = StartCoroutine(StarveCoroutine());
        }

        private void StopFuelCalculation ()
        {
            if (_fuelCoroutine != null)
            {
                StopCoroutine(_fuelCoroutine);
            }
        }

        private IEnumerator StarveCoroutine()
        {
            while(_slider.value > 0)
            {
                _slider.value -= _fuelDectreaseValueInTick;
                yield return _fuelUpdateTickInSecondsDelay;
            }

            OnFuelIsZero?.Invoke();
        }
    }
}