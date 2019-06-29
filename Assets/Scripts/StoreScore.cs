using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;

public class StoreScore
{
    public static HighScores highScores;
    public const string scoreFile = "highScores.json";

    public void saveScores()
    {
        string filePath = Path.Combine(Application.persistentDataPath, scoreFile);

        string json = JsonConvert.SerializeObject(highScores, Formatting.Indented);

        File.WriteAllText(filePath, json);
    }

    public void loadScores()
    {
        string filePath = Path.Combine(Application.persistentDataPath, scoreFile);
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            highScores = JsonConvert.DeserializeObject<HighScores>(json);
        }
        else
        {
            highScores = new HighScores();
            highScores.resetScores();
            saveScores();
        }
    }
}

public class HighScores
{
    public static int[] highScores = new int[3];

    public void resetScores()
    {
        for (int i = 0; i < 3; i++)
        {
            highScores[i] = 0;
        }
    }
}
