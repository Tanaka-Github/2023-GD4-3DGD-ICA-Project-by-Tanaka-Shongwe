using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBarrel : MonoBehaviour {

public Transform it;
public float speed = 60f;
float dcount ;
public float delay = 4f;



public void  Seek (Transform _target){


	it = _target;
}
	// Use this for initialization
	void Start () {
		
		dcount = delay;
	}

	void Update ()
	{
        dcount -= Time.deltaTime;

		if(it == null )
		{
           
           Destroy(gameObject);
		   return;

		}

		if(dcount <= 1f)
		{
          Destroy(gameObject);

		}

		Vector3 dir = it.position - transform.position;
		float distanceThisFrame = speed * Time.deltaTime;

		if (dir.magnitude <= distanceThisFrame )
		{
             HitTarget();
			 return;

		}
		transform.Translate(dir.normalized * distanceThisFrame, Space.World );
      // transform.Translate(0,0,9);
	}
	
	// Update is called once per frame
	void HitTarget() 
	{
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
