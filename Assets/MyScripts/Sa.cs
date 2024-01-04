using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sa : MonoBehaviour {

	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
		if (other.name == "DarkenBot 3 1 1 1")
		{
           Destroy(gameObject);

		}
		
	}
}
