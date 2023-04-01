using UnityEngine;

namespace GameManager
{
    public class MenuManager : MonoBehaviour
    {
        [SerializeField] private MenuManagerUI _menuManager;
        [SerializeField] private LevelManager _levelManager;

        private void OnEnable()
        {
            _menuManager.OnStartGame += StartGame;
            _menuManager.OnExitGame += QuitGame;
        }

        private void OnDisable()
        {
            _menuManager.OnStartGame -= StartGame;
            _menuManager.OnExitGame -= QuitGame;
        }

        private void StartGame()
        {
            Time.timeScale = 1;
            _levelManager.LoadFirstLevel();
        }

        private void QuitGame()
        {
            Application.Quit();
        }
    }
}