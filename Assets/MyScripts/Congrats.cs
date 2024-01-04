using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Congrats : MonoBehaviour {

//public Transform Player;
public Transform Canvas;
public float Count = 3f ;

	void Update () {
		Count-=Time.deltaTime;
	}

	// Use this for initialization
	void Awake ()


	{

		/* if(Canvas.gameObject.activeInHierarchy == false)
			{
                   Canvas.gameObject.SetActive(true);
			if (Count <= 0f){Time.timeScale = 0;}
                    Player.GetComponent<ThirdPersonCharacterController>(). enabled =false;
					//Player.GetComponent<CursorStyle>().enabled = false;
				
			         Cursor.visible = true;
		            Cursor.lockState = CursorLockMode.None;
					}
        else
		{
			Canvas.gameObject.SetActive(false);
			Time.timeScale = 1;
		 Player.GetComponent<ThirdPersonCharacterController>(). enabled =true;
        // Player.GetComponent<CursorStyle>().enabled = true;
			 Cursor.visible = false;
		           Cursor.lockState = CursorLockMode.Locked;
		}
	*/}
	
	// Update is called once per frame
}
