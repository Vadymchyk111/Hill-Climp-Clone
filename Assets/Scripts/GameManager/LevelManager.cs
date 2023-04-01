using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameManager
{
    public class LevelManager : MonoBehaviour
    {
        private readonly int _menuIndex = 0;
        private int _levelIndex = 1;

        public void LoadFirstLevel()
        {
            _levelIndex = 1;
            SceneManager.LoadScene(_levelIndex);
        }

        public void LoadNextLevel()
        {
            if (_levelIndex < SceneManager.sceneCount - 1)
            {
                SceneManager.LoadScene(++_levelIndex);
            }
            else
            {
                LoadFirstLevel();
            }
        }

        public void LoadMenu()
        {
            SceneManager.LoadScene(_menuIndex);
        }
    }
}