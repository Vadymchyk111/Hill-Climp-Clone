using System;
using PlayerPrefsValues;
using TMPro;
using UnityEngine;

namespace UI
{
    public class MoneyUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private ScriptableObjectInt _moneyCount;

        private void Start()
        {
            UpdateUI(_moneyCount.Value.Value, _moneyCount.MinValue.Value, _moneyCount.MaxValue.Value);
        }

        private void OnEnable()
        {
            _moneyCount.OnValueChanged += UpdateUI;
        }

        private void OnDisable()
        {
            _moneyCount.OnValueChanged -= UpdateUI;
        }

        private void UpdateUI(int value, int minValue, int maxValue)
        {
            _text.text = _moneyCount.Value.RestoreValue().ToString();
        }
    }
}