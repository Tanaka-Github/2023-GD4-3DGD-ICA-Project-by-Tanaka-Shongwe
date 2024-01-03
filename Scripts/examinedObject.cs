using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class examinedObject : MonoBehaviour
{
    public GameObject PickUpText;
    public GameObject ItemToPlayer;
    public GameObject pANEL;

    private void Start()
    {
        //ItemToPlayer.SetActive(false);
        //ItemToPlayer.SetActive(false);
        PickUpText.SetActive(false);
    }

    public void OnTriggerStay(Collider other)
    {
     /*  PickUpText.SetActive(true);        
       if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                pANEL.gameObject.SetActive(true);
                
                pANEL = null;

                ItemToPlayer.SetActive(false);
                this.gameObject.SetActive(false);
            }
        }*/
    }



}
