using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;

public class StoreScore
{
    public static HighScores scoreClass;
    public const string scoreFile = "highScores.json";

    public static void saveScores()
    {
        string filePath = Path.Combine(Application.persistentDataPath, scoreFile);

        string json = JsonConvert.SerializeObject(scoreClass, Formatting.Indented);

        File.WriteAllText(filePath, json);
    }

    public static void loadScores()
    {
        string filePath = Path.Combine(Application.persistentDataPath, scoreFile);
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            scoreClass = JsonConvert.DeserializeObject<HighScores>(json);
        }
        else
        {
            scoreClass = new HighScores();
            scoreClass.resetScores();
            saveScores();
        }
    }
}

public class HighScores
{
    public List<int> highScores = new List<int>();

    public void resetScores()
    {
        highScores.Clear();
        for (int i = 0; i < 3; i++)
        {
            highScores.Add(0);
        }
    }
}
