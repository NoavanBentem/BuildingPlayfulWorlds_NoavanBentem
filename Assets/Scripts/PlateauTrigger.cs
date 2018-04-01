using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlateauTrigger : MonoBehaviour {

    public ParticleSystem Tree1;
    public ParticleSystem Platteau;
    private bool agent0 = false;
    private bool agent1 = false;
    private bool agent2 = false;
    private bool agent3 = false;
    public GameObject Agent0;
    public GameObject Agent1;
    public GameObject Agent2;
    public GameObject Agent;


	// Use this for initialization
	void Start () {
		
	}

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Agent0")
        {
            agent0 = true;
        }
        else if (collision.gameObject.tag == "Agent1")
        {
            agent1 = true;
        }
        else if (collision.gameObject.tag == "Agent2")
        {
            agent2 = true;
        }
        else if (collision.gameObject.tag == "Agent3")
        {
            agent3 = true;
        }

        if (agent0 && agent1 && agent2 && agent3)
        {
            Debug.Log("YES");
            Platteau.Play();
            SceneManager.LoadScene("NextStage");
        }
        
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Agent0")
        {
            agent0 = false;
        }
        else if (collision.gameObject.tag == "Agent1")
        {
            agent1 = false;
        }
        else if (collision.gameObject.tag == "Agent2")
        {
            agent2 = false;
        }
        else if (collision.gameObject.tag == "Agent3")
        {
            agent3 = false;
        }
    }
}
