using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractPanel : MonoBehaviour
{
    public GameObject Panel;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TurnOff()
    {

        if (Input.GetKey(KeyCode.E))
        {

           // Panel.gameObject.SetActive(true);
        }

        Debug.Log("DisplayOn");
    }
}

    

