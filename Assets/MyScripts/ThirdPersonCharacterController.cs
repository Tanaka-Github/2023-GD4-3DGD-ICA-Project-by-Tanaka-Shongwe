using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacterController : MonoBehaviour {

// public AudioClip Walk;
//public AudioSource Audio;
 public float Speed;
    public float rotationSpeed;
    public Animator animator;
    public CharacterController characterController;
    private float originalStepOffset;
    private float? lastGroundedTime;
    private float? jumpButtonPressedTime;



    public float speed;

    public float jumpSpeed;
    public float jumpButtonGracePeriod;

    public float ySpeed;

    void Update () {
		
		PlayerMovement();
	}
	 void PlayerMovement()
	 {

       float hor = Input.GetAxis("Horizontal");
       float ver = Input.GetAxis("Vertical");
	   Vector3 playerMovement = new Vector3(hor, 0f,ver) * Speed * Time.deltaTime;
        float magnitude = Mathf.Clamp01(playerMovement.magnitude) * Speed;
        transform.Translate(playerMovement, Space.Self);

        if (characterController.isGrounded)
        {
            lastGroundedTime = Time.time;
        }
        // GetComponent<AudioSource>().Play();

        if (playerMovement != Vector3.zero)
        {
            animator.SetBool("IsMoving", true);
            Quaternion toRotation = Quaternion.LookRotation(playerMovement, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
        else
        {
            animator.SetBool("IsMoving", false);
        }

    }
}
