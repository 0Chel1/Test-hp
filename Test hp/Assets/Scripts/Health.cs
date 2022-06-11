using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public bool Def;

    public void TakeHit(float damage)
    {
        if(Def == true)
        {
            damage /= 2;
            health -= damage;
        }
        else
        {
            health -= damage;
        }

        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
