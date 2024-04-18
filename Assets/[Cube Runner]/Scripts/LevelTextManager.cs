using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace adk
{
    public class LevelTextManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI levelNoText;
        private float currentLvlNo = 0;
        private void Awake()
        {
            currentLvlNo = SceneManager.GetActiveScene().buildIndex + 1;
            //Debug.Log(currentLvlNo);
            levelNoText.text = "Level " + currentLvlNo;
        }
        
        /*public void UpdateLevelNo()
        {
            currentLvlNo = SceneManager.GetActiveScene().buildIndex + 1;
        }*/
    }
}
