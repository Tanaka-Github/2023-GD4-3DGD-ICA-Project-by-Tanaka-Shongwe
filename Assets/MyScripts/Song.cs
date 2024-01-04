using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Song : MonoBehaviour {
	//public AudioSource SONG;
	public float count = 0f;
	public float delay= 0f;
	// Use this for initialization
	void Start () {
		count = delay;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	count-=Time.deltaTime;

	if(count <= 0f)
	{

        Destroy(gameObject);

	}

	}
}
