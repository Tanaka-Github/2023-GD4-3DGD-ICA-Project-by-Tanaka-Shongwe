using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawning : MonoBehaviour {
	
	public Transform Canvas;
	public float Rate = 1f;
	public float Counting;
	public GameObject Player;

	// Use this for initialization
	void Update () 
	{
	    Counting-=Time.deltaTime;
		Happen();
	}
	
	// Update is called once per frame
	void Happen () {
if(Counting <= 0)
{
	  Counting = 1000f/Rate;
      Instantiate (Canvas, transform.position , transform.rotation);
         End();
		 Time.timeScale = 0;
}
}
  void End()
  {
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




 */ }


  }


