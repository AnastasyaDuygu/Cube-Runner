using TMPro;
using UnityEngine;

namespace adk
{
    public class ScoreManager : MonoBehaviour
    {
        public TextMeshProUGUI scoreText;
        public Transform player;

        public bool levelStop = false;
        private void Awake()
        {
            scoreText.text = "0";
        }
        void Update()
        {
            if (levelStop == true) return;
            float zero = player.position.z * 10;
            float smaller = zero / 10;
            scoreText.text = smaller.ToString("0");
        }
        public void EnableScore()
        {
            gameObject.SetActive(true);
        }
        public void LevelStop()
        {
            levelStop = true;
        }
    }
}
