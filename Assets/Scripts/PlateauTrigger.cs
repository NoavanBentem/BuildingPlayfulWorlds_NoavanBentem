using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlateauTrigger : MonoBehaviour {

    public ParticleSystem Tree1;
    public ParticleSystem Platteau;
    private bool A0 = false;
    private bool A1 = false;
    private bool A2 = false;
    private bool A3 = false;



	// Use this for initialization
	void Start () {
		
	}

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Agent0")
        {
            A0 = true;
        }

        if (collision.gameObject.name == "Agent1")
        {
            A1 = true;
        }

        if (collision.gameObject.name == "Agent2")
        {
            A2 = true;
        }

        if (collision.gameObject.name == "Agent3")
        {
            A3 = true;
        }

    }

    private void Update()
    {
        if (A0 == true && A1 == true && A2 == true && A3 == true)
        {
            SceneManager.LoadScene("NextStage");
            Debug.Log("NextStageMOFO");
        }
    }
}
