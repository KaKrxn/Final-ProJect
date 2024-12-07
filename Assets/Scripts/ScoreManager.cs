using UnityEngine;
using TMPro;

public class ScoreManager
{
    public TMP_Text scoreText;

    public ScoreManager()
    {
        scoreText = GameObject.FindObjectOfType<TMP_Text>();
    }

    public bool IsScoreTextAssigned()
    {
        return scoreText != null;
    }

    public void AddScore()
    {
        GameMana.nScore++;
        scoreText.text = GameMana.nScore.ToString();
    }
}
