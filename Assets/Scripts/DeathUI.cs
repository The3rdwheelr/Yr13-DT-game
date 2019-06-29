using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DeathUI : MonoBehaviour
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
        if (PlayerManager.playerHealth == 0)
        {
            updateDeathScore();
            Die();
        }
    }

    void Die()
    {
        player.SetActive(false);
        deathUI.SetActive(true);
        gameUI.SetActive(false);
        pauseUI.SetActive(false);
    }

    void updateDeathScore()
    {
        scoreText.text = "Your Score Was:\n" + PlayerManager.playerScore;
    }

    void checkForHighScore()
    {
        StoreScore.loadScores();

    }
}
