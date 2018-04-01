using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHit : MonoBehaviour {

    //Checks if bullet hit something 
    void OnCollisionEnter(Collision collision)
    {

        GameObject enemy = collision.gameObject;
        if (enemy.name == "Target")
        {
            
            Destroy(enemy);
        }
        Destroy(gameObject); // Destroys bullet on collision

    }
	
}
