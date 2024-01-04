using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacterController : MonoBehaviour {

// public AudioClip Walk;
//public AudioSource Audio;
 public float Speed;
 

	void Update () {
		
		PlayerMovement();
	}
	 void PlayerMovement()
	 {

       float hor = Input.GetAxis("Horizontal");
       float ver = Input.GetAxis("Vertical");
	   Vector3 playerMovement = new Vector3(hor, 0f,ver) * Speed * Time.deltaTime;
	   transform.Translate(playerMovement, Space.Self);
                // GetComponent<AudioSource>().Play();

      if(Input.GetButton("Jump"))
	  {
            transform.Translate(0,1,0);


	  }

	 }
}
