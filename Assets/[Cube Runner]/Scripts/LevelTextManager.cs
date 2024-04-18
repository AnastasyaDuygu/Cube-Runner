using UnityEngine;
using UnityEngine.SceneManagement;

namespace adk
{
    public class LevelTextManager : MonoBehaviour
    {
        public float currentLvlNo = 0;
        private void Awake()
        {
            currentLvlNo = SceneManager.GetActiveScene().buildIndex + 1;
            //Debug.Log(currentLvlNo);
        }

        public void UpdateLevelNo()
        {
            currentLvlNo = SceneManager.GetActiveScene().buildIndex + 1;
        }
    }
}
