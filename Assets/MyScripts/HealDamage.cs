using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealDamage : MonoBehaviour {

public bool isDamaging;
public float damage = 20;
	// Use this for initialization
	
	private void OnTriggerStay (Collider col)
	{
         if (col.tag == "Player")
		  col.SendMessage((isDamaging)?"TakeDamage":"HealDamage",Time.deltaTime * damage); 
             

		 


	}

	
}
