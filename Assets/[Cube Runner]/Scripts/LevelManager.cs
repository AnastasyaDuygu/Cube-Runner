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
    }
}
