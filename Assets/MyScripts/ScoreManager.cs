using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

	


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

	Text text;

	// Use this for initialization
	void Awake () {
		
		text = GetComponent <Text>();
		score = 0;
		
    Count = Delay;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		text.text = "Apples Collected: " +score;

 		if(score >= 2)
		{       Count -= Time.deltaTime; 

		if (Count <= 0){
			   	 Count = 1000f/Drate;
                 Instantiate(D, X.position , X.rotation );
				 Clip.enabled = false;
				 Instantiate(Text2, transform.position , transform.rotation);
				 Skv();
		}
				
		}

//Count -= Time.deltaTime;

		
	}

	public void Skv(){
	
 	
	
				
		}

	
}
