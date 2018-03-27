using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour

{

    public float health = 100f;
    public GameObject MainTree;
    public GameObject Bridge;
    public Transform SpawnPoint;

    void Start()
    {
        
    }

    //Checking health if health is zero and calling the die function
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f && GameObject.FindWithTag("MainTree"))
        {
            Die();
            SpawnWood();

        }



    }

    // Makes enemy dissapear
    void Die()
    {
        Destroy(gameObject);
    }

    // Makes MainTrees spawn the bridges
    void SpawnWood()
    {
        Instantiate(Bridge, SpawnPoint.position, SpawnPoint.rotation);
    }

}

