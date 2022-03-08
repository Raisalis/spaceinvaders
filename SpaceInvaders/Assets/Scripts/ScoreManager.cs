using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ScoreManager : MonoBehaviour
{
    private int score;
    private int hiscore;
    public TMP_Text scoreText;
    public TMP_Text hiscoreText;
    

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        hiscore = PlayerPrefs.GetInt("Highscore");
        hiscoreText.text = String.Format("{0:0000}", hiscore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore(int change)
    {
        score += change;
        scoreText.text = String.Format("{0:0000}", score);

        if(score > hiscore) {
            updateHighScore();
        }
    }

    public void updateHighScore() {
        hiscore = score;
        PlayerPrefs.SetInt("Highscore", hiscore);
        PlayerPrefs.Save();
        hiscoreText.text = String.Format("{0:0000}", hiscore);
    }

    public void gameOver() {
        Debug.Log("Game Over!");
    }
}
