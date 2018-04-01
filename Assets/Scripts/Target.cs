using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour

{

    public float health = 100f;

    void Start()
    {
        
    }

    //Checking health if health is zero and calling the die function
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            GetComponent<AudioSource>().Play();
            Die();
        }
    }

    // Makes target dissapear
    void Die()
    {
        Destroy(gameObject);
    }

}

