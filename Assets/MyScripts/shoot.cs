using UnityEngine;

public class shoot : MonoBehaviour {

 public float damage = 10f;
 public float range = 100f;
 public float FireRate= 15f;

public Camera Tps;

private float nextTimetoFire = 0f;
public GameObject HOLE;
public GameObject Sparks;

void Update () {
		
		if (Input.GetButton("Fire1") && Time.time >= nextTimetoFire)
		{
           nextTimetoFire = Time.time +  4f / FireRate ;
           Blast();

		}
	}  
	
	
     
 void Blast ()
	 {
        RaycastHit hit;
        if (Physics.Raycast(Tps.transform.position, Tps.transform.forward, out hit , range)){

			Debug.Log(hit.transform.name);

			dead kia = hit.transform.GetComponent<dead>();

        if (kia != null )
		    {

			kia.TakeDamage(damage);
			Instantiate (Sparks , hit.point , Quaternion.LookRotation(hit.normal) );
		
			}
			Instantiate(HOLE, hit.point , Quaternion.LookRotation(hit.normal));
		}



	 }



}
