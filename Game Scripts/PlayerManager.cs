using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public static int playerHealth;
    public static int playerMaxHealth = 5; 
    public static int playerScore;

    public TextMeshProUGUI scoreUI;
    public TextMeshProUGUI healthUI;

    private void Start()
    {
        //player starts on 3 lives
        playerHealth = 3;
        Time.timeScale = 1;
    }
    // Update is called once per frame
    void Update()
    {
        // this is what displays score on the in game UI
        scoreUI.text = "Score: " + playerScore.ToString();
    }
}
