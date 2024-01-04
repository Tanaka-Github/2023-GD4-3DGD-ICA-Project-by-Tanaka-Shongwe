using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TorQ : MonoBehaviour {

public GameObject Player;
public string loadlevel;
public Transform Canvas;
public Transform Canvas2;
	// Use this for initialization
	void Start () {

		Cursor.visible=true;
		Cursor.lockState = CursorLockMode.None;

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
   public void  tryagain ()
   {
         SceneManager.LoadScene(loadlevel);
		/*if(Canvas.gameObject.activeInHierarchy == false)
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
		*/}
 
 


	


   
 public void Quit()
 {
        Application.Quit();


 }


}


