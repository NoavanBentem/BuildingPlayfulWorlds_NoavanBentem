using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AgentControl : MonoBehaviour 
{

    public Transform target;
    NavMeshAgent agent;
    private PickableObject Player;
    public Transform lookHere;

	// Use this for initialization
	void Start () 
    {
        Player = GameObject.FindWithTag("Player").GetComponent<PickableObject>();
	}
	


	// Update is called once per frame
    [SerializeField]
	void Update () 
    {

        if (Player.currentTransform != null)
        {
            agent = this.GetComponent<NavMeshAgent>();
            agent.SetDestination(target.position);
            transform.LookAt(lookHere);
        }


    }
}
