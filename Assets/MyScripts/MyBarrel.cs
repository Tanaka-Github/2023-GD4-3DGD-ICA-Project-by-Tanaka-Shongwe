using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBarrel : MonoBehaviour {

public  Transform barrell ;
public GameObject Blast;
	public Transform Target;
	float mouseX, mouseY;
	public float RotationSpeed = 1;
	public float FireRate = 15f;
	private float nextTimeWeFire = 0f;
	public ParticleSystem MuzzleEX;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Fire1") && Time.time >= nextTimeWeFire)
		{
             nextTimeWeFire = Time.time + 4f / FireRate;
            Blastoff();
            Debug.Log("JUSTICE!");
             MuzzleEX.Play();
				GetComponent<AudioSource>().Play();
		}

	}

	void Blastoff()
	{
      GameObject Muzzle = (GameObject)Instantiate(Blast, barrell.position , barrell.rotation);
	  HBLAST bullett = Muzzle.GetComponent<HBLAST>();
      

	}
	void LateUpdate()
	{
       CamControl();

	}
	void CamControl()
	{
       mouseX += Input.GetAxis("Mouse X") *RotationSpeed;
	   mouseY -= Input.GetAxis("Mouse Y") *RotationSpeed;
	   mouseY = Mathf.Clamp(mouseY ,-35, 60);

        transform.LookAt(Target);

		Target.rotation = Quaternion.Euler(mouseY, mouseX , 0);
		//Player.rotation = Quaternion.Euler(0, mouseX , 0);
	}

	
		



}
