using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class DeathManager : MonoBehaviour
{
    public GameObject deathUI;
    public GameObject gameUI;
    public GameObject pauseUI;
    public GameObject player;

    public TextMeshProUGUI scoreText;

    void Start()
    {
        deathUI.SetActive(false);
        gameUI.SetActive(true);
        pauseUI.SetActive(false);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("GameScene");

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerManager.playerHealth <= 0)
        {
            updateDeathScore();
            saveHighScores();
            Die();
        }
    }

    void Die()
    {
        PlayerManager.playerScore = 0;
        player.SetActive(false);
        deathUI.SetActive(true);
        gameUI.SetActive(false);
        pauseUI.SetActive(false);
    }

    void updateDeathScore()
    {
        scoreText.text = "Your Score Was:\n" + PlayerManager.playerScore;
    }

    void saveHighScores()
    {
        StoreScore.loadScores();
        //Add Score
        StoreScore.scoreClass.highScores.Add(PlayerManager.playerScore);
        StoreScore.scoreClass.highScores.Sort();
        StoreScore.scoreClass.highScores.Reverse();
        StoreScore.scoreClass.highScores.RemoveAt(StoreScore.scoreClass.highScores.Count - 1);

        //Add name
        int scoreIndex;
        if (StoreScore.scoreClass.highScores.Contains(PlayerManager.playerScore))
        {
            scoreIndex = StoreScore.scoreClass.highScores.IndexOf(PlayerManager.playerScore);
            StoreScore.scoreClass.playerNames.Insert(scoreIndex, StartMenu.playerName);
            StoreScore.scoreClass.playerNames.RemoveAt(StoreScore.scoreClass.playerNames.Count - 1);
        }

        StoreScore.saveScores();
    }
}
