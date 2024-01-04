using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blasting : MonoBehaviour {

public Transform Player;
public float  speed = 70f;
 float DCountdown ;
public float delay = 3f;

public void Seek (Transform _target){
  
   Player = _target;


}
void Start()
{ 
    DCountdown = delay;



}
	
	// Update is called once per frame
	void Update () {

		DCountdown -= Time.deltaTime;
		
		if (Player == null)
		{
            Destroy(gameObject);
             return;

		}
            
		if (DCountdown <= 4f)
		{
             Destroy(gameObject);
		}

	    Vector3 dir = Player.position - transform.position;
         float distanceThisFrame =  speed * Time.deltaTime;

		 if (dir.magnitude <= distanceThisFrame)
		 {
             HitTarget();
            return;
		 }
              transform.Translate (0,0,9) ;
	        



	}
         void HitTarget(){

            
            Destroy(gameObject);
			
		 }
		   
		  void OnTriggerEnter (Collider other)
		  {
              if(other.name == "Barrier")
			  {

                Destroy(gameObject);


			  }


		  }
		   






	
}
