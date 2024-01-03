using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonController : MonoBehaviour
{

    public float RotationSpeed = 1;
    public Transform Target, Player;
    float mouseX, mouseY;

    // Start is called before the first frame update
    void Start()
    {
        //This will allow me to prevent the player from seeing the mouse cursor and locking it into gameplay
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }


    // Update is called once per frame
    void Update()
    {
        CamControl();
    }

    void CamControl()
    {
        //These are mouse inputs that move the player
        mouseX += Input.GetAxis("Mouse X") * RotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * RotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -35, 60);

        transform.LookAt(Target);

        Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        Player.rotation = Quaternion.Euler(0, mouseX, 0);
    }
}
