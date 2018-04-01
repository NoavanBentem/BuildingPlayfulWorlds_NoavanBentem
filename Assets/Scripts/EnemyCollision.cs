using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyCollision : MonoBehaviour 
{
    public GameObject Agent;
    public Texture SadFace;
    public Texture HappyFace;
    public ParticleSystem FX_Agent_Die;
    public float damage = 10f;
    public float health = 100f;

   

    // Use this for initialization
    void Start () {
        Agent = GameObject.FindWithTag("agent");

	}
	
	// Update is called once per frame
	void Update () 
    {
        if (health <= 0)
        { 
            Die();
            SceneManager.LoadScene("Start");

        }
	}


    void OnCollisionEnter(Collision other)
    {
        // Checked of agent wordt geraakt door enemy
        if (other.gameObject.tag == "enemy")
        {
            health = health - damage;
            GetComponent<AudioSource>().Play();
            Agent.GetComponent<Renderer>().material.mainTexture = SadFace;

        }
        // Zorgt er voor dat hij blij is als hij niet wordt gesmacked
        else
        {
            Agent.GetComponent<Renderer>().material.mainTexture = HappyFace;
        }
    }


    //Laat agent verdwijnen en speelt particles af
    void Die()
    {
        
        FX_Agent_Die.Play();
        Destroy(Agent);
    }

  
}
