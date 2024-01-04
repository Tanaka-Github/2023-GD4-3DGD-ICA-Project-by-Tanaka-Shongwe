using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour {

public Image CurrentHP;
public Text RatioText;
private float  hitpoint= 150;
private float MaxHP=150;
public Transform canvas;
public string level;

public float Countdown = 0f;
public  float delay = 0f;
	// Use this for initialization
private	void Start () 
{
     Countdown = delay;
	UpdateHealthBar() ;


}


void Update()
{ 
		 
	      
     Countdown-=Time.deltaTime;





}
	
	// Update is called once per frame
private	void UpdateHealthBar () 
    {
		float ratio = hitpoint/ MaxHP;
		CurrentHP.rectTransform.localScale = new Vector3(ratio, 1,1);
		RatioText.text = (ratio *100).ToString("0") + '%';
	}
	private void TakeDamage(float damage)
	{
        hitpoint -= damage;

		if(hitpoint <0){

         hitpoint = 0;
		 Debug.Log("dED");
	      Begin();
		  

	
///	Time.timeScale = 0;
	
	

	 
    

		
		}
 UpdateHealthBar();

	}
	private void HealDamage (float heal)
	{

        hitpoint += heal;

		if(hitpoint < MaxHP)
		{

         hitpoint = MaxHP;
		 

		}
         UpdateHealthBar();

	}
     void Begin()
	 {
		 if (Countdown <= 0f){
 
         SceneManager.LoadScene(level);

		 }



	 }
}
