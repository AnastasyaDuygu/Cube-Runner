using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public Transform player;

    private void Awake()
    {
        scoreText.text = "0";
    }
    void Update()
    {
        float zero = player.position.z;
        float smaller = zero / 10;
        scoreText.text = smaller.ToString("0");
    }

    public void EnableScore()
    {
        gameObject.SetActive(true);
    }
}
