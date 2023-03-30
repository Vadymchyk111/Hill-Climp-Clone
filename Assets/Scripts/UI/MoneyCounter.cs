using PlayerPrefsValues;
using TMPro;
using UnityEngine;

namespace UI
{
    public class MoneyCounter : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private ScriptableObjectInt _moneyCount;
        
        private int _money;

        private void Start()
        {
            Init();
        }

        public void AddMoney(int moneyCount)
        {
            _money += moneyCount;
            _text.text = _money.ToString();
            _moneyCount.Value.ChangeValue(_moneyCount.Value.RestoreValue() + moneyCount);
        }

        public void RemoveMoney(int moneyCount)
        {
            _money -= moneyCount;
            _text.text = _money.ToString();
           
        }

        private void Init()
        {
            _money = _moneyCount.Value.RestoreValue();
            _text.text = _money.ToString();
        }
    }
}