using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace UI
{
    public class GameManagerUI : MonoBehaviour
    {
        [SerializeField] private GameObject _mainPanel;
        [SerializeField] private GameObject _loosePanel;
        [SerializeField] private GameObject _winnerPanel;
        [SerializeField] private Button _restartButton;

        private void OnEnable()
        {
            _restartButton.onClick.AddListener(RestartScene);
        }

        private void OnDisable()
        {
            _restartButton.onClick.RemoveListener(RestartScene);
        }

        public void SetLoosePanel()
        {
            _restartButton.gameObject.SetActive(true);
            _mainPanel.SetActive(false);
            _loosePanel.SetActive(true);
        }
        
        public void SetWinnerPanel()
        {
            _restartButton.gameObject.SetActive(true);
            _mainPanel.SetActive(false);
            _winnerPanel.SetActive(true);
        }

        private void RestartScene()
        {
            SceneManager.LoadScene(0);
        }
    }
}