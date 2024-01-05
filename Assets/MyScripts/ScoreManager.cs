using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class ScoreManager : MonoBehaviour {

	public static int score;
	public string level;
	public Transform X;
    public GameObject D;
	public float Drate= 1f;
	public float Count = 1f;
	public float Delay = 0f;
	public AudioSource Clip;
	public GameObject Text2;
	public GameObject Player;

	Text text;

	// Use this for initialization
	void Awake () {
		
		text = GetComponent <Text>();
		score = 0;
		
    Count = Delay;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		text.text = "Apples Collected: " + score;

 		if(score >= 2)
		{       Count -= Time.deltaTime;
			//  Instantiate(D, transform.position, transform.rotation);
			//  Instantiate(D, X.position, X.rotation);
		
			
			if (Count <= 0){
			   	 Count = 1000f/Drate;
              //   Instantiate(D, X.position , X.rotation );
				 Clip.enabled = false;
				 Instantiate(Text2, transform.position , transform.rotation);
                WinGame();

            }
				
		}

//Count -= Time.deltaTime;

		
	}
    public void WinGame()
	{

            if(D.gameObject.activeInHierarchy == false)
			{
                   D.gameObject.SetActive(true);
			if (Count <= 0f){Time.timeScale = 0;}
                    Player.GetComponent<ThirdPersonCharacterController>(). enabled =false;
					//Player.GetComponent<CursorStyle>().enabled = false;
				
			         Cursor.visible = true;
		            Cursor.lockState = CursorLockMode.None;
					}
        else
		{
			D.gameObject.SetActive(false);
			Time.timeScale = 1;
		 Player.GetComponent<ThirdPersonCharacterController>(). enabled =true;
        // Player.GetComponent<CursorStyle>().enabled = true;
			 Cursor.visible = false;
		           Cursor.lockState = CursorLockMode.Locked;
		}
	}



	
}
