using System;
using UnityEngine;
using UnityEngine.UI;

namespace UI.GameManager
{
    public class GameManagerUI : MonoBehaviour
    {
        public event Action OnRestartGame;
        public event Action OnNextLevel;
        public event Action OnMenuOpened;

        [SerializeField] private GameObject _mainPanel;
        [SerializeField] private GameObject _loosePanel;
        [SerializeField] private GameObject _winnerPanel;
        [SerializeField] private Button _restartButton;
        [SerializeField] private Button _nextLevelButton;
        [SerializeField] private Button _menuButton;

        private GameObject _currentPanel;

        private void Start()
        {
            _currentPanel = _mainPanel;
            _loosePanel.SetActive(false);
            _winnerPanel.SetActive(false);
        }

        private void OnEnable()
        {
            _restartButton.onClick.AddListener(RestartScene);
            _nextLevelButton.onClick.AddListener(SetupNewLevel);
            _menuButton.onClick.AddListener(OpenMenu);
        }

        private void OnDisable()
        {
            _restartButton.onClick.RemoveListener(RestartScene);
            _nextLevelButton.onClick.RemoveListener(SetupNewLevel);
            _menuButton.onClick.RemoveListener(OpenMenu);
        }

        public void SetLoosePanel()
        {
            SwitchPanel(_loosePanel);
        }
        
        public void SetWinnerPanel()
        {
            SwitchPanel(_winnerPanel);
        }
        
        public void SetMainPanel()
        {
            SwitchPanel(_mainPanel);
        }

        private void RestartScene()
        {
            OnRestartGame?.Invoke();
        }

        private void SetupNewLevel()
        {
            OnNextLevel?.Invoke();
        }

        private void OpenMenu()
        {
            OnMenuOpened?.Invoke();
        }

        private void SwitchPanel(GameObject panel)
        {
            _currentPanel.SetActive(false);
            _currentPanel = panel;
            _currentPanel.SetActive(true);
        }
    }
}