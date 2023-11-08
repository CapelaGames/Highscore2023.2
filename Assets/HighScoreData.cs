using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;


[System.Serializable]
public class HighScoreData
{
    public float[] scores;
    public string[] names;

    public HighScoreData()
    {
        scores = new float[10];
        names = new string[10];
    }

    public HighScoreData(float[] scores, string[] names)
    {
        this.scores = scores;
        this.names = names;
    }

    public HighScoreData(string[] names)
    {
        this.names=names;

        scores = new float[names.Length];

        for(int i = 0; i < scores.Length ;i++) 
        {
            scores[i] = Random.Range(0.0f, 100.0f);
        }
        
    }

    
}




[System.Serializable]
public class Float3
{
    public float x, y, z;

    public Float3(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public Float3(Vector3 vector)
    {
        ToFloat3(vector);
    }

    Vector3 ToVector()
    {
        return new Vector3(x, y, z);
    }

    void ToFloat3(Vector3 vector)
    {
        x = vector.x;
        y = vector.y; 
        z = vector.z;
    }
}

