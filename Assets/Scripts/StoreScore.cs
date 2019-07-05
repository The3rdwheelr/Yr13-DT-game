using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;

public class StoreScore
{
    public static HighScores scoreClass;
    public const string scoreFile = "highScores.json";

    // Function to serialize the class and then store it in the json file at filepath
    public static void saveScores()
    {
        string filePath = Path.Combine(Application.persistentDataPath, scoreFile);

        string json = JsonConvert.SerializeObject(scoreClass, Formatting.Indented);

        File.WriteAllText(filePath, json);
    }

    // Function to load the scores from filepath and then deserialize it, storing it in a public-static variable
    public static void loadScores()
    {
        string filePath = Path.Combine(Application.persistentDataPath, scoreFile);
        // If the file exists, save
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            scoreClass = JsonConvert.DeserializeObject<HighScores>(json);
        }
        // If it doesn't, make a new one and save it to filepath
        else
        {
            scoreClass = new HighScores();
            scoreClass.resetScores();
            saveScores();
            loadScores();
        }
    }
}

public class HighScores
{
    // list of top 3 high scores
    public List<int> highScores = new List<int>();
    // list of player names to match the high scores
    public List<string> playerNames = new List<string>();

    // resets the scores and names
    public void resetScores()
    {
        highScores.Clear();
        playerNames.Clear();
        for (int i = 0; i < 3; i++)
        {
            highScores.Add(0);
            playerNames.Add("-----");
        }
    }
}
