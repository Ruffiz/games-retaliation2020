using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour {

    private NavMeshAgent myAgent;
    public Transform target;

	void Start () {
        myAgent = GetComponent<NavMeshAgent>();

        
	}
	
	// Update is called once per frame
	void Update () {

        myAgent.SetDestination(target.position);

    }

}
