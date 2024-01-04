using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
public int  ScoreValue = 1;
public GameObject DarkenBot;
public GameObject Enemy;
public GameObject EXPL;
public bool isDead = false;
public float Dcount = 0f;
public float Delay = 0f;
public float DarkenBotRate = 1f;



	// Use this for initialization
	void Start(){
 
		Dcount = Delay;
		}

void Update ()
{
	   Begin();
                Dcount -= Time.deltaTime;
}
		 void Begin(){

if ( Dcount <= 0f)
{
 
 Arrive();
   Dcount = 5f/DarkenBotRate;

}
      }

      	
	void Arrive()
	{
        Instantiate(DarkenBot, transform.position , transform.rotation);
		Instantiate(EXPL, transform.position, transform.rotation);
        Destroy(gameObject,2f);

	}
}
	
	

	

