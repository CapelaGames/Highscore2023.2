using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGame : MonoBehaviour
{
    public HighScoreData highScoreData;

    public void RunSaveGame()
    {
        JsonSaveLoad.Save(highScoreData);
    }

    public void RunLoadGame()
    {
        highScoreData = JsonSaveLoad.Load();
    }
}
