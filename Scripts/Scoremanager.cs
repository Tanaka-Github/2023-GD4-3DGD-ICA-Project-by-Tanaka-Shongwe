using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public int ScoreValue = 1;
    public GameObject DarkenBot;
    public GameObject Apples;
    public GameObject EXPL;
    public bool isCollected = false;
    public float collectCount = 0f;
    public float Delay = 0f;
    public float DarkenBotRate = 1f;



    // Use this for initialization
    void Start()
    {

        collectCount = Delay;
    }

    void Update()
    {
        Begin();
        collectCount -= Time.deltaTime;
    }
    void Begin()
    {

        if (collectCount <= 0f)
        {

            Arrive();
            collectCount = 5f / DarkenBotRate;

        }
    }


    void Arrive()
    {
        Instantiate(DarkenBot, transform.position, transform.rotation);
       // Instantiate(EXPL, transform.position, transform.rotation);
        Destroy(gameObject, 2f);

    }
}





