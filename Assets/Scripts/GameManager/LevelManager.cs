using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameManager
{
    public class LevelManager : MonoBehaviour
    {
        public void LoadLevel()
        {
            SceneManager.LoadScene(0);
        }
    }
}