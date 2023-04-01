using System;
using UnityEngine;
using UnityEngine.UI;

namespace GameManager
{
    public class MenuManagerUI : MonoBehaviour
    {
        public event Action OnStartGame;
        public event Action OnExitGame;
        
        [SerializeField] private Button _startButton;
        [SerializeField] private Button _exitButton;

        private void OnEnable()
        {
            _startButton.onClick.AddListener(StartGame);
            _exitButton.onClick.AddListener(ExitGame);
        }

        private void OnDisable()
        {
            _startButton.onClick.RemoveListener(StartGame);
            _exitButton.onClick.RemoveListener(ExitGame);
        }
        
        private void StartGame()
        {
            OnStartGame?.Invoke();
        }

        private void ExitGame()
        {
            OnExitGame?.Invoke();
        }
    }
}