using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DTracker : MonoBehaviour {

	public float LR = 1000f;
    public GameObject aura;
	NavMeshAgent agent; 
	public Transform Player;

	// Use this for initialization
	void Start () 
	{
		Player = Playermanager.instance.player.transform;
		agent = GetComponent<NavMeshAgent>();
		Instantiate(aura,transform.position, transform.rotation);
	} 
	
	// Update is called once per frame
	void Update () {
     
		float dista = Vector3.Distance(Player.position, transform.position);

		if( dista <= LR)
		{
           agent.SetDestination(Player.position);

		{
           agent.SetDestination(Player.position);

		if(dista <= agent.stoppingDistance)
		{
             faceTarget();
             

		}
		
	}
     


}
	}
	 void OnDrawGizmoSelected()
	  {
         Gizmos.color = Color.red;
		 Gizmos.DrawWireSphere(transform.position, LR);
      }
    
	void faceTarget()
	{

   Vector3 direct = ( Player.position - transform.position ) .normalized;
   Quaternion lookRotation =   Quaternion.LookRotation(new Vector3(direct.x,0, direct.z));
   transform.rotation = Quaternion.Slerp(transform.rotation ,lookRotation, Time.deltaTime* 30f);





	}

}
	