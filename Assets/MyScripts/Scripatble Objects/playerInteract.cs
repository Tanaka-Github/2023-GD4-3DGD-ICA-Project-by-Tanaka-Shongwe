using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteract : MonoBehaviour
{
    public Transform cam;
    public float playerActivateDistance;
    public GameObject Display;
    public GameObject Display2;
    public GameObject TextDisplay;
    public bool Active = false;


    // Start is called before the first frame update
    void Start()
    {
        //  Display.SetActive(false);
        TextDisplay.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        /* if (Input.GetKey(KeyCode.F))
         {
            // Display.gameObject.SetActive(false);

             DisplayOn();
             //     Enter(other);
         }
          else if (Input.GetKey(KeyCode.Escape))
         {
            // Display.gameObject.SetActive(false);

             DisplayOff();
             //     Enter(other);
         }


 */

        /* if (Input.GetKey(KeyCode.Escape))
         {
             // Display.gameObject.SetActive(false);

             DisplayOff();
             //     Enter(other);
         }
 */

        if (Input.GetKey(KeyCode.G))
        {
            DisplayOff();

        }
        RaycastHit hit;
        Active = Physics.Raycast(cam.position, cam.TransformDirection(Vector3.forward), out hit, playerActivateDistance);

        // Enter();
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

    private void DisplayOff()
    {


        if (Display2.gameObject.activeInHierarchy == true && Display.gameObject.activeInHierarchy == false)
        {
            Display2.gameObject.SetActive(false);
            Display.gameObject.SetActive(true);
            Time.timeScale = 1;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }


        /*   if(Display.gameObject.activeInHierarchy == false)
           {
               Display.gameObject.SetActive(true);
               Time.timeScale = 0;
               Cursor.visible = true;
               Cursor.lockState = CursorLockMode.None;
           }
           else
           {
               Display.gameObject.SetActive(false);
               Time.timeScale = 1;
               Cursor.visible = false;
               Cursor.lockState = CursorLockMode.Locked;
           }

           if (Display2.gameObject.activeInHierarchy == false)
           {
               Display2.gameObject.SetActive(true);
               Time.timeScale = 0;
           }
           else
           {
               Display2.gameObject.SetActive(false);
               Time.timeScale = 1;
           }*/
        /*/////////////////////////////////////////
         * 
         * 
                if (Display2.gameObject.activeInHierarchy == true && Display.gameObject.activeInHierarchy == false)
                {
                    Display2.gameObject.SetActive(false);
                    Display.gameObject.SetActive(true);
                    Time.timeScale = 0;
                }
                else
                {
                    Display2.gameObject.SetActive(false);
                    Display.gameObject.SetActive(true);
                    Time.timeScale = 1;
                }*/

    }

    private void Enter()
    {


        // }

    }

    /*  public void OnTriggerEnter(Collider other)
      {
          TextDisplay.gameObject.SetActive(true);

          if (other.tag == "Examine")
          {
              TextDisplay.gameObject.SetActive(true);
              //   Display.gameObject.SetActive(true);

              if (Input.GetKey(KeyCode.E))
              {
               //   Display.gameObject.SetActive(true);

                  //     Enter(other);

              }
              // this.gameObject.SetActive(false);
              *//*
               * 
                 if (Input.GetKeyDown(KeyCode.E) && Active == false && Display.gameObject.activeInHierarchy == false)
                 {*//*
              if (other.tag == "Examine")
              {

                  // }


                  if (other.gameObject.tag == "Player")
                  {

                      // }
                  }
              }
          }
      }*/

    private void OnTriggerStay(Collider other)
    {
      

          if (other.gameObject.tag == "X")
           {
            TextDisplay.SetActive(true);

            if (Input.GetKey(KeyCode.F))
            {
                DisplayOn();

            }  
            
        }


    }

    public void Enter(Collider other)
    {
        // Display.gameObject.SetActive(false);


        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {

            }
        }
    }



    public void OnTriggerExit(Collider other)
    {
        //TextDisplay.gameObject.SetActive(false);
        //  Display.gameObject.SetActive(false);

      TextDisplay.SetActive(false);

        if (other.tag == "X")
        {
            if (Display.gameObject.activeInHierarchy == false & Input.GetKeyDown(KeyCode.G) && Active == false)
            {
             //   TextDisplay.gameObject.SetActive(false);
                Display.gameObject.SetActive(false);


                // }
            }
/*
            if (other.gameObject.tag == "Player")
            {
                if (Input.GetKey(KeyCode.G))
                {
                    //     Display.gameObject.SetActive(false);

                    {
                        TextDisplay.gameObject.SetActive(false);

                    }
                    // }
                }
            }*/
        }
    }

    private void DisplayOn()
    {

        /* if (Display.gameObject.activeInHierarchy == false)
         {
             Display.gameObject.SetActive(true);
             Time.timeScale = 0;
             Cursor.visible = true;
             Cursor.lockState = CursorLockMode.None;
         }
         else
         {
             Display.gameObject.SetActive(false);
             Time.timeScale = 1;
             Cursor.visible = false;
             Cursor.lockState = CursorLockMode.Locked;
         }*/

        if (Display2.gameObject.activeInHierarchy == false && Display.gameObject.activeInHierarchy == true)
        {
            Display2.gameObject.SetActive(true);
            Display.gameObject.SetActive(false);
            Time.timeScale = 0;


        }
      
        /*    else
            {
                Display2.gameObject.SetActive(false);
                Display.gameObject.SetActive(true);
                Time.timeScale = 1;
            }*/


    }

}







