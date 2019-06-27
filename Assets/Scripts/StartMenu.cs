using UnityEngine;
using Unity;
using UnityEngine.SceneManagement;
using TMPro;


public class StartMenu : MonoBehaviour
{

    public TMP_InputField nameInput;
    public static string playerName;

    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (nameInput.text == "")
        {
            playerName = "Guest";
        }
        else
        {
            playerName = nameInput.text;
        }
        Debug.Log(playerName);
    }
}
