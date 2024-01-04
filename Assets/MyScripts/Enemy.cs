using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {

public float LookRadius = 100f;

NavMeshAgent agent; 
public Transform Player;


	// Use this for initialization
	void Start () {
        
		Player = Playermanager.instance.player.transform;
		agent = GetComponent<NavMeshAgent>();
		  
	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance(Player.position, transform.position);

		if(distance <= LookRadius){

			agent.SetDestination(Player.position);
			
			{

		   agent.SetDestination(Player.position);

		   if(distance <=agent.stoppingDistance)
		   {
              //Attack the target
			   FaceTarget();

		   }
		}
		
	}
	}

	void OnDrawGizmosSelected ()
	{
 Gizmos.color = Color.red;
 Gizmos.DrawWireSphere(transform.position, LookRadius);


	}

void FaceTarget()
{
  Vector3 direct = ( Player.position - transform.position ) .normalized;
  Quaternion lookRotation =   Quaternion.LookRotation(new Vector3(direct.x,0, direct.z));
  transform.rotation = Quaternion.Slerp(transform.rotation ,lookRotation, Time.deltaTime* 100f);



}


	}

