using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour, IClickable, IDamagable
{
    public float health { get; set; }

    private void Start()
    {
        health = 100;
    }

    public void Interact()
    {
        Debug.Log("circle");

        ((IDamagable)this).Damage(10f);
    }


}
