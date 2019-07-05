using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class DeathManager : MonoBehaviour
{
    // UI parent empties
    public GameObject deathUI;
    public GameObject gameUI;
    public GameObject pauseUI;

    // Player GameObject
    public GameObject player;

    // Game Over Score Text
    public TextMeshProUGUI scoreText;

    void Start()
    {
        // Make sure that the correct UI is showing at the start of the game
        deathUI.SetActive(false);
        gameUI.SetActive(true);
        pauseUI.SetActive(false);
    }

    public void PlayAgain()
    {
        // Reload the scene (resets everything)
        SceneManager.LoadScene("GameScene");
    }

    // Update is called once per frame
    void Update()
    {
        // If the player's health reaches zero
        if (PlayerManager.playerHealth <= 0)
        {
            // Set the score that shows on the death screen
            updateDeathScore();
            // Save the score to the list of high scores
            saveHighScores();
            // Run the Die function
            Die();
        }
    }

    void Die()
    {
        // Sort the different UIs
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
        // Load the scores from the .json file
        StoreScore.loadScores();

        // Add the player score to the list
        StoreScore.scoreClass.highScores.Add(PlayerManager.playerScore);
        // Sort the list (Lowest -> Highest)
        StoreScore.scoreClass.highScores.Sort();
        // Reverse the list so that it is (Highest -> Lowest)
        StoreScore.scoreClass.highScores.Reverse();
        // Remove the fourth entry of the list (to keep top 3)
        StoreScore.scoreClass.highScores.RemoveAt(StoreScore.scoreClass.highScores.Count - 1);

        int scoreIndex = StoreScore.scoreClass.highScores.IndexOf(PlayerManager.playerScore);
        StoreScore.scoreClass.playerNames.Insert(scoreIndex, StartMenu.playerName);


        // Save the scores to the .json file
        StoreScore.saveScores();
        // Reset the playerScore
        PlayerManager.playerScore = 0;
    }
}
