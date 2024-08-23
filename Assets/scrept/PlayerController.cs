using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    void Start()
    {
        UpdateScoreText();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Prize"))
        {
            score++;
            Destroy(other.gameObject);
            UpdateScoreText();
        }
        else if (other.gameObject.CompareTag("Obstacle"))
        {
            Destroy(other.gameObject);
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}



