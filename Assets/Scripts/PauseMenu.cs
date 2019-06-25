using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameisPaused = false;

    public GameObject PauseMenuUI; //reference for setting the UI part of the Menu active/inactive

    private void Start()
    {
        PauseMenuUI.gameObject.SetActive(false);        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //when esc key is pressed, check if game is paused, if it is, resume. If game is not paused, pause game
        {
            if (GameisPaused)
            {
                Resume();
            }else
            {
                Pause();
            }
        }
    }

    public void Resume () // method to unpause the game using Time.timescale
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = (false);
    }

    void Pause () //method to pause the game using Time.timescale
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = (true);
    }
    public void LoadMenu ()
    {
        SceneManager.LoadScene("Menu");
    }
}
