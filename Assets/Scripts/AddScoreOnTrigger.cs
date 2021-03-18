using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScoreOnTrigger : MonoBehaviour
{
    public int scoreToAdd = 10;
    public ScoreKeeper scoreKeeper;

    void Start()
    {
;       GameObject scoreKeeperObject = GameObject.FindGameObjectWithTag("ScoreKeeper");


        scoreKeeper = scoreKeeperObject.GetComponent<ScoreKeeper>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            scoreKeeper.AddScore(scoreToAdd);
        }
    }
}
