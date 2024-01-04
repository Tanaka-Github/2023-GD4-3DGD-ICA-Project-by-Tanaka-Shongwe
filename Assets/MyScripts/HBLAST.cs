using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HBLAST : MonoBehaviour {

public float Delay = 1f;
float   NVM ;
	// Use this for initialization
	void Start () {
		
		NVM = Delay;
                
  
		
	}
	
	// Update is called once per frame
	void Update () {
		
        NVM -= Time.deltaTime;

		if ( NVM <= 1f)
		{
			 	Destroy(gameObject);
				 
		}


		transform.Translate(0,0,39);
	}
}
