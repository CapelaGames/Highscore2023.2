using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class JsonSaveLoad
{
    private static string file = Application.dataPath + "/highscores.json";

    public static void Save(HighScoreData data)
    {
        string json = JsonUtility.ToJson(data);

        File.WriteAllText(file, json);

    }

    public static HighScoreData Load() 
    {
        string json = File.ReadAllText(file);

        return JsonUtility.FromJson<HighScoreData>(json);

    }
}
