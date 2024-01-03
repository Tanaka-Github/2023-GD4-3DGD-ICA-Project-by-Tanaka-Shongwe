using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPickup : MonoBehaviour
{
    [SerializeField]
    public GameObject ScoreText;
    public int Score = 0;


    // Start is called before the first frame update
    void Update()
    {
        transform.Rotate(0, 9, 0);  
    }

    // Update is called once per frame
     void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            Score += 50;
            ScoreText.GetComponent<Text>().text = "SCORE: " + Score;
            
            Debug.Log("Collected");
            Destroy(gameObject); 
        }
        
    }
}
