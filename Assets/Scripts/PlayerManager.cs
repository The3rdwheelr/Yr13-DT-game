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
        playerHealth = 3;
    }
    // Update is called once per frame
    void Update()
    {
        scoreUI.text = playerScore.ToString();
        healthUI.text = playerHealth.ToString();
    }
}
