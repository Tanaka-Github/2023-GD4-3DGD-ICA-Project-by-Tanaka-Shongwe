
using UnityEngine;

public class SpottingTarget : MonoBehaviour {


public Transform me;
public float FireRate = 5f;
public float Countdown = 0f;
public float range= 200f;

	
void Start ()
{
InvokeRepeating("UpdateTarget",0f,0.5f);

}

void UpdateTarget()
{
GameObject[] Players = GameObject.FindGameObjectsWithTag("Player");
float ShortestDistance = Mathf.Infinity;
GameObject nearestPlayer = null;
foreach(GameObject Player in Players )

{
	float distancetoPlayer = Vector3.Distance(transform.position ,Player.transform.position);
	if (distancetoPlayer < ShortestDistance)
	{
        ShortestDistance = distancetoPlayer;
		nearestPlayer = Player;

	}
}
if(nearestPlayer != null && ShortestDistance <= range)
{

    me = nearestPlayer.transform;


}

}
	// Update is called once per frame
	void Update () {
     

	 if ( me == null)
	 {
        return;
		 
     }

    	}


	void OnDrawGizmoSelected ()
	{
       Gizmos.color = Color.green;
	   Gizmos.DrawWireSphere(transform.position, range);

	}
	
}
