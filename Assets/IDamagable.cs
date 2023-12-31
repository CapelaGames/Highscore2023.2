using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamagable
{
    float health {  get; set; }

    void Damage(float damage )
    {
        health -= damage;
        Debug.Log("Damaged: " + health);
    }
}
