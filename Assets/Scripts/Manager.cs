using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public GameObject barrel;
    public int barrelTime;
    public int barrelInt;
    // Start is called before the first frame update
    void Start()
    {
        barrelInt = Random.Range(60, 300);
    }

    // Update is called once per frame
    void Update()
    {
        barrelTime--;
     
        if(barrelTime <= 0)
        {
            barrelInt = Random.Range(60,300);
            barrelTime = barrelInt;
            Instantiate(barrel);
        }
    }
}
