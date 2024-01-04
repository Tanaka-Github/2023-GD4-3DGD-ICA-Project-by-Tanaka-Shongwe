using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class CursorUnlocked : MonoBehaviour {

public string loadlevel;
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
		 Time.timeScale = 1;
		


   }
 public void Quit()
 {
        Application.Quit();
		Debug.Log("Exit");


 }


}
