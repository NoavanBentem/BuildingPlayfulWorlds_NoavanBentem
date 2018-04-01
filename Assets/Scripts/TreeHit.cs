using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeHit : MonoBehaviour
{

    public float health = 100f;
    public GameObject Bridge;
    public Transform SpawnPoint;

    void Start()
    {

    }

    //Checking health if health is zero and calling the die function
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Instantiate(Bridge, SpawnPoint.position, SpawnPoint.rotation);
            Die();
        }



    }

    // Makes enemy dissapear
    void Die()
    {
        Destroy(gameObject);
    }
}
