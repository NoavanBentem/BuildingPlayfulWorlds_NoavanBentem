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
            FX_Agent_Die.Play();
            Die();
            SceneManager.LoadScene("Start");

        }
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "enemy")
        {
            health = health - damage;
            GetComponent<AudioSource>().Play();
            Agent.GetComponent<Renderer>().material.mainTexture = SadFace;

        }
    }

    void Die()
    {
        
        GetComponent<AudioSource>().Play();
        Destroy(Agent);
    }

   

}
