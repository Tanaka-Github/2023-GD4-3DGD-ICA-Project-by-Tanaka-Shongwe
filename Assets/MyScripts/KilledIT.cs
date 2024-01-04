using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KilledIT : MonoBehaviour {

    public GameObject bulletPrefab;
public Transform Barrel;
public Transform me;
public float FireRate = 1f;
public float Countdown = 0f;
public float range= 10f;

	
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
     
	 if (me == null)
	 {
         return;
		 
     }

       if(Countdown <= 0f)
		{
	GetComponent<AudioSource>().Play();
		Firing();
		Countdown = 1f/FireRate;
		}

		Countdown -= Time.deltaTime; 
	}

	 void Firing ()
	 {
        
     GameObject BulletGo = (GameObject)Instantiate(bulletPrefab, Barrel.position, Barrel.rotation);
             DBarrel bullet = BulletGo.GetComponent<DBarrel>();
                	GetComponent<AudioSource>().Play();
			 if(bullet != null )
			 {
                bullet.Seek(me);

           
			 }


	 }
	void OnDrawGizmoSelected ()
	{
       Gizmos.color = Color.red;
	   Gizmos.DrawWireSphere(transform.position, range);

	}
	
}



