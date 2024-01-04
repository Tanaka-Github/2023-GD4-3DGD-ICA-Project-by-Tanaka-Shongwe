
using UnityEngine;

public class SpottingTarget : MonoBehaviour {

public GameObject bulletPrefab;
public Transform Barrel;
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
     
Barrel.transform.LookAt(me);

	 if ( me == null)
	 {
        return;
		 
     }

       if(Countdown <= 0f)
		{
	GetComponent<AudioSource>().Play();
		Firing();
		Countdown = 0.8f/FireRate;
		}

		Countdown -= Time.deltaTime; 
	}

	 void Firing ()
	 {
        
     GameObject BulletGo = (GameObject)Instantiate(bulletPrefab, Barrel.position, Barrel.rotation);
             blasting bullet = BulletGo.GetComponent<blasting>();
                	GetComponent<AudioSource>().Play();
			 if(bullet != null )
			 {
                bullet.Seek(me);

           
			 }


	 }
	void OnDrawGizmoSelected ()
	{
       Gizmos.color = Color.green;
	   Gizmos.DrawWireSphere(transform.position, range);

	}
	
}
