using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Barrels : MonoBehaviour
{
    public float startSpeed;
    public Rigidbody2D rig;
    public Manager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<Manager>();
        rig.gameObject.GetComponent<Rigidbody2D>();
        rig.velocity = new Vector2(startSpeed, 0);
        transform.position = gameManager.transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Barrelend")
        {
            Destroy(gameObject);
        }
    }
}
