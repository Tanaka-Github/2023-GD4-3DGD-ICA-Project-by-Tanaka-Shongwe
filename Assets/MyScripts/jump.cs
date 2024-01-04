using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {

public GameObject Wall;
//public GameObject Shocken;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKey("e"))
		{
            Instantiate(Wall, transform.position, transform.rotation);
           /// Instantiate(Shocken, transform.position , transform.rotation);


		}
	}
}
