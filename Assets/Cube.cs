using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour, IClickable
{
    public void Interact()
    {
        Debug.Log("Cube clicked on");
    }
}
