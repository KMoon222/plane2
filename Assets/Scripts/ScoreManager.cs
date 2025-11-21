using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public TMPro.TextMeshPro scoreText;
    public int score = 0;

    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score.ToString();
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
