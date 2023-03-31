using Car;
using UI;
using UnityEngine;

namespace GameManager
{
    public class GameManager: MonoBehaviour
    {
        [SerializeField] private Flag _flag;
        [SerializeField] private FuelController _fuelController;
        [SerializeField] private GameManagerUI _gameManagerUI;

        private void OnEnable()
        {
            _flag.OnReachedPoint += _gameManagerUI.SetWinnerPanel;
            _fuelController.OnDied += _gameManagerUI.SetLoosePanel;
        }

        private void OnDisable()
        {
            _flag.OnReachedPoint -= _gameManagerUI.SetWinnerPanel;
            _fuelController.OnDied -= _gameManagerUI.SetLoosePanel;
        }
    }
}