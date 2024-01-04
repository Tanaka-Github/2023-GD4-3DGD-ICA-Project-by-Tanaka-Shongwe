using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour {

public GameObject JumpingWall;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

if (Input.GetKey("e")){
		Instantiate(JumpingWall, transform.position , transform.rotation);
	}
}
}