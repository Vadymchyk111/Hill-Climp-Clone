using Car;
using UI.GameManager;
using UnityEngine;

namespace GameManager
{
    public class GameManager: MonoBehaviour
    {
        [SerializeField] private Flag _flag;
        [SerializeField] private FuelController _fuelController;
        [SerializeField] private GameManagerUI _gameManagerUI;
        [SerializeField] private LevelManager _levelManager;

        private void OnEnable()
        {
            _flag.OnReachedPoint += WinGame;
            _fuelController.OnDied += LooseGame;
            _gameManagerUI.OnRestartGame += RestartGame;
        }

        private void OnDisable()
        {
            _flag.OnReachedPoint -= WinGame;
            _fuelController.OnDied -= LooseGame;
            _gameManagerUI.OnRestartGame -= RestartGame;
        }

        private void WinGame()
        {
            Time.timeScale = 0;
            _gameManagerUI.SetWinnerPanel();
        }

        private void LooseGame()
        {
            Time.timeScale = 0;
            _gameManagerUI.SetLoosePanel();
        }

        private void RestartGame()
        {
            Time.timeScale = 1;
            _levelManager.LoadLevel();
        }
    }
}