using UnityEngine;
using UnityEngine.SceneManagement;

namespace adk
{
    public class LevelManager : MonoBehaviour
    {
        public void ReloadCurrentLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        public void LoadNextLevel()
        {
            Debug.Log("Scene Count: " + SceneManager.sceneCount);
            if(SceneManager.GetActiveScene().buildIndex+1 >= SceneManager.sceneCount) //if current scene is last scene
                SceneManager.LoadScene(0); //load first level, could potentially add an event for this***
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //load next scene
            }  
        }
    }
}
