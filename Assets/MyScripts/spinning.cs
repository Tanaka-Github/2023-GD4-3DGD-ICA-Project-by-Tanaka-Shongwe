using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinning : MonoBehaviour {

    public int ScoreValue = 1;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate(0,9,0);

	}

	private void OnTriggerEnter(Collider other)
	{

		if (other.name == "Player")
		{
			ScoreManager.score += ScoreValue;
			Destroy(gameObject);
		}
	}


}
