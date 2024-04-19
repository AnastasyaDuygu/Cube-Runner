using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace adk
{
    public class LevelManager : MonoBehaviour
    {
        public UnityEvent onLastLevel;
        public void ReloadCurrentLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        public void LoadNextLevel()
        {
            bool isLastLevel = SceneManager.GetActiveScene().buildIndex + 1 >= SceneManager.sceneCountInBuildSettings;
            if (isLastLevel) {
                onLastLevel.Invoke(); // menu manager enable last level canvas
            } else {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //load next scene
            }  
        }
        public void LoadFirstScene()
        {
            SceneManager.LoadScene(0);
        }
    }
}
