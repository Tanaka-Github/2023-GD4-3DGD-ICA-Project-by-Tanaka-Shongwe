using UnityEngine;

public class dead : MonoBehaviour {
 
 public float Health = 50f;
 public bool hasExploded = false;
 public GameObject ExpEffect;
 public AudioSource BYE;
 public int ScoreValue = 1;
public GameObject Text;
 public Transform player;
 public GameObject End;
 public GameObject Canvas;
public Transform Player;
public float Countdown = 5f;


 void Start()
 {
    //player = GameObject.FindWithTag("Player").transform;
 

 }

 public void Update()
 {
      Text.GetComponent<TextMesh>().text = Health.ToString("00")+"%";
     //Text.transform.LookAt(player);
      Countdown -=Time.deltaTime;
      

 }


 public void TakeDamage ( float amount)
 {
    Health -= amount;
     if (Health <= 0f)
	 {  GetComponent<AudioSource>().Play();
         Die();
         Update();
         Explode();
         hasExploded = true;
         Timing();
       Instantiate(Canvas, transform.position , transform.rotation);
       
	 }
    
      
}
 

 void Die (){
    
    ScoreManager.score += ScoreValue;
	 Destroy(gameObject);
     GetComponent<AudioSource>().Play();
     //Record();
     
 }
 void Explode()
 {
     Instantiate(ExpEffect, transform.position , transform.rotation);
      GetComponent<AudioSource>().Play();
      Instantiate (End , transform.position , transform.rotation );
       
      
 }

 public void Timing()
 {/*
     
       if(Canvas.gameObject.activeInHierarchy == false)
			{
                   Canvas.gameObject.SetActive(true);
				//   Time.timeScale = 0;
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



 */}

 }

