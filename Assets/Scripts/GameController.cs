using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject gameOverScreen;

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        gameOverScreen.SetActive(false);
    }

}
