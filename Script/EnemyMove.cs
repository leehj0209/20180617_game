using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour {

    [SerializeField]
    private GameObject target;
    [SerializeField]
    private Transform trans;
    NavMeshAgent agent;

    // Use this for initialization
    void Start () {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = 1;
        agent.destination = target.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
       
	}
}
