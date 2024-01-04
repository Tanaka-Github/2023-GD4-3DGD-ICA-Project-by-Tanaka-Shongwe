using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PauseGameMenu : MonoBehaviour {

public Transform Canvas;
public Transform Player;
public Transform Canvas2;

// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Escape))
		{ 
			  Pause();

		}
		
 if(Input.GetKey("p"))
 {

    Application.Quit();
    Debug.Log("Exit");
	
 }
	}

public	void Pause()
	{

if(Canvas.gameObject.activeInHierarchy == false)
			{
                   Canvas.gameObject.SetActive(true);
				   Time.timeScale = 0;
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

		if(Canvas2.gameObject.activeInHierarchy == false)
			{
                   Canvas2.gameObject.SetActive(true);
				   Time.timeScale = 0;
                  // Player.GetComponent<ThirdPersonCharacterController>(). enabled =false;
			         Cursor.visible = true;
		            Cursor.lockState = CursorLockMode.None;
		
			}
        else
		{
			Canvas2.gameObject.SetActive(false);
			Time.timeScale = 1;
			  Player.GetComponent<ThirdPersonCharacterController>(). enabled =true;
			 // Player.GetComponent<CursorStyle>().enabled = true;
			   Cursor.visible = false;
		           Cursor.lockState = CursorLockMode.Locked;
		}
 
 


	}
public void Quit()
{

	Debug.Log("Quit");
   Application.Quit();


}

public void Exit(){

 if(Input.GetKey("P"))
 {

    Application.Quit();
    Debug.Log("Exit");
 }
}
}


