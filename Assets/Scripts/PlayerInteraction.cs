using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    public Transform cam;
    public float playerActivateDistance;
    public GameObject Display;
   public bool Active = false;
    // Start is called before the first frame update
    void Start()
    {
        Display.SetActive(false);
    
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Active = Physics.Raycast(cam.position, cam.TransformDirection(Vector3.forward), out hit, playerActivateDistance);
        /*





                if (Input.GetKeyDown(KeyCode.E) && Active == false)
                {
                    UiDisplayON();
                }


                if (Input.GetKeyDown(KeyCode.E) && Active == true)
                {

                    UiDisplayOFF();
                }


                *//* switch (Input.GetKeyDown(KeyCode.E))
                 {
                     case true:
                         Display.SetActive(true);
                         Active= true;
                         break;

                     case false:
                         Display.SetActive(false);
                         Active = false;
                         break;

                     default:
                 }*//*
         */


/*
        if (Display.gameObject.activeInHierarchy == false & Input.GetKeyDown(KeyCode.E) && Active == false)
        {
            Display.gameObject.SetActive(true);
            Time.timeScale = 0;

        }
        else
        {
            Display.gameObject.SetActive(false);
            Time.timeScale = 1;

        }

*/


/*
        if (Display.gameObject.activeInHierarchy == false && Input.GetKeyDown(KeyCode.E) && Active == false)
        {
            Display.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            Display.gameObject.SetActive(false);
            Time.timeScale = 1;
        }*/


    }


        public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Examine")
        {/*
            if (Input.GetKeyDown(KeyCode.E) && Active == false && Display.gameObject.activeInHierarchy == false)
            {*/
            Active = true;
                Display.SetActive(true);
          // }
        }
    }
  

    public void OnTriggerExit(Collider other)
    {

        if (other.tag == "Examine")
        {
           /* if (Display.gameObject.activeInHierarchy == false & Input.GetKeyDown(KeyCode.Escape) && Active == false)
            {*/
                Display.gameObject.SetActive(false);


          // }
        }

    }

   


}
