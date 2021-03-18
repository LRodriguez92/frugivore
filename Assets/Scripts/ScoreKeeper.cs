using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    private int score;
    public Text scoreText;

    private int highScore;
    public Text highScoreText;

    private string highScoreKey = "highScoreKey";

    public bool wipeData = false;

    public void Start()
    {
        if(wipeData)
        {
            PlayerPrefs.DeleteKey(highScoreKey);
        }

        if (PlayerPrefs.HasKey(highScoreKey))
        {
            highScore = PlayerPrefs.GetInt(highScoreKey);
            highScoreText.text = "High Score: " + highScore;
        }
    }

    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;

        scoreText.text = "SCORE: " + score;

        if (score > highScore)
        {
            highScore = score;

            // Save to Player Prefs
            PlayerPrefs.SetInt(highScoreKey, highScore);
            PlayerPrefs.Save();

            highScoreText.text = "High Score: " + highScore;
        }
    }

}
