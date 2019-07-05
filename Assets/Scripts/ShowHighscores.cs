using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowHighscores : MonoBehaviour
{
    public TextMeshProUGUI scoreTexts;
    string text;
    // Start is called before the first frame update
    void Start()
    {
        StoreScore.loadScores();
    }

    // Update is called once per frame
    void Update()
    {
        text = "";
        for (int i = 0; i < StoreScore.scoreClass.highScores.Count; i++)
        {
            string displayName = StoreScore.scoreClass.playerNames[i];
            if (StoreScore.scoreClass.playerNames[i].Length > 5)
            {
                displayName = displayName.Substring(0, 5);
            }

            text += displayName + ": ";
            text += StoreScore.scoreClass.highScores[i] + "\n";
        }
        scoreTexts.text = text;
    }
}
