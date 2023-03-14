using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D rig;
    public float moveSpeedx;
    public float moveSpeedy;
    public float xInput;
    public float yInput;
    public bool onLadder;
    public bool onGround;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        onLadder = false;
        onGround = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");

        if(xInput != 0)
        {
            print(xInput);
            rig.velocity = new Vector2(moveSpeedx * xInput, rig.velocity.y);
        }
        if(yInput != 0)
        {
            if (onGround)
            {
                onGround = false;
                rig.velocity = new Vector2(rig.velocity.x, moveSpeedy);
            }
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Platform"))
        {
            onGround = true;
        }
    }
}
