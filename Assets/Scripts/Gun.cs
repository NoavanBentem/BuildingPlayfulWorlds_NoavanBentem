using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;
    public ParticleSystem ShotsFired;
    public GameObject ShotImpact;

	void Start () {
		
	}
	
	//Calls shooter fuction when leftmouse is pushed
	void Update () 
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shooter();
        }    
	}

    void shooter()
    {
        //Sounds and particles for shooting
        ShotsFired.Play();
        GetComponent<AudioSource>().Play();

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {

            //Checking if raycast hits the enemy or tree and calls for smackings
            Target target =  hit.transform.GetComponent<Target>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }

            TreeHit tree = hit.transform.GetComponent<TreeHit>();
            if (tree != null)
            {
                tree.TakeDamage(damage);
            }


            Instantiate(ShotImpact, hit.point, Quaternion.LookRotation(hit.normal));
        }
    }
}
