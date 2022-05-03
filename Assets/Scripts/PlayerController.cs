using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float moveInput;
    private float speed = 10f;



    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if(moveInput < 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
        }
        else 
        {
             this.GetComponent<SpriteRenderer>().flipX = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(moveInput * speed, rb2d.velocity.y);
        //rb2d.velocity = new Vector2(Input.acceleration.x * speed, rb2d.velocity.y);


    }
}
