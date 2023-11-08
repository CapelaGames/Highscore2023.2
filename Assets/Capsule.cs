using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour, IDamagable
{
    public float health { get; set; }

    private void Start()
    {
        health = 50;
    }
}
