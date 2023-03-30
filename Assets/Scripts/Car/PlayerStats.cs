using UI;
using UnityEngine;

namespace Car
{
    public class PlayerStats : MonoBehaviour
    {
        [SerializeField] private FuelController _fuelController;
        [SerializeField] private MoneyCounter _moneyCounter;

        public void RecoveryFuel(float fuelCount)
        {
            _fuelController.RecoveryFuel(fuelCount);
        }

        public void GetMoney(int moneyCount)
        {
            _moneyCounter.AddMoney(moneyCount);
        }
    }
}