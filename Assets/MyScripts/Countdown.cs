using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

	Text text ;

	float Timer = 120f ;
	float Timer1 = 120f;
	 public float Speed = 5f;
    public bool playing = true;
	 float TU = 120f;
	// Use this for initialization
	void Start () {
		
		text = GetComponent<Text>(); 
	}
	
	// Update is called once per frame
	void Update () {

		TU -=Time.deltaTime;
		Stop();
		if (playing == true){
			
		Timer1 -= Time.deltaTime * Speed;
			Timer -= Time.deltaTime * Speed;
		string minutes = Mathf.Floor (( Timer1 % 3600)/ 60 ).ToString("00");
		string seconds = (Timer % 60 ).ToString("00");
		text.text = minutes + ":" + seconds;
		}
		
	}

	void Stop(){

	if( TU <= 0f){

	playing = false; }


	}
}
