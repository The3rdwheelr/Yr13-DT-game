using UnityEngine.UI;
using UnityEngine;

public class HealthScriptUI : MonoBehaviour
{
    // health from the previous frame
    public int oldHealth;

    // sprites for either filled heart or empty heart
    public Sprite[] heartTypes;
    // heart ui slots
    public Image[] heartSlots;

    // Start is called before the first frame update
    void Start()
    {
        // set values for the start of the game
        PlayerManager.playerHealth = 3;
        oldHealth = PlayerManager.playerHealth;
        HeartUIUpdate();
    }

    // Update is called once per frame
    void Update()
    {
        // if the amount of health has changed
        if (oldHealth != PlayerManager.playerHealth)
        {
            oldHealth = PlayerManager.playerHealth;
            HeartUIUpdate();
        }
    }

    // Update the Health UI
    void HeartUIUpdate()
    {
        // hearts that need to be filled
        int toFillHearts = PlayerManager.playerHealth;

        for (int i = 0; i < heartSlots.Length; i++)
        {
            // fill the needed hearts
            if (i < toFillHearts)
            {
                heartSlots[i].sprite = heartTypes[1];
            }
            // set the rest to empty
            else
            {
                heartSlots[i].sprite = heartTypes[0];
            }
        }
    }

}
