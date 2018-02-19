using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour {
    private AudioSource walk;
    private Rigidbody character;
   
	// Use this for initialization
	void Start () {
        walk = (AudioSource)GetComponent(typeof(AudioSource));
        character = (Rigidbody)GetComponent(typeof(Rigidbody));

        
    }
	// Update is called once per frame
	void Update () {
        if (character.velocity.magnitude >= 0.2)
        {
            walk.Play();
            walk.loop = true;
        }
		
	}
}
