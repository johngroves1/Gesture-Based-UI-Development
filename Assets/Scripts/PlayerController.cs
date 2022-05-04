using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float moveInput;
    private float speed = 10f;

    public float fuel = 0f;
    private int fuelInt;
    public float topScore = 0.0f;

    public Text scoreText;
    public Text fuelText;



    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if (rb2d.velocity.y > 0 && transform.position.y > topScore)
        {
            topScore = transform.position.y;
        }

        scoreText.text = Mathf.Round(topScore).ToString();

        if (moveInput < 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (transform.position.y + 50 < topScore)
        {
            SceneManager.LoadScene(2);
        }

        //For Development - Mousedown to use jetpack
        if (Input.GetMouseButton(0))
        {
            if (fuel > 0)
            {
                rb2d.AddForce(Vector3.up * 5f);
                fuel -= 0.1f;
                fuelInt = (int)fuel;
                fuelText.text = fuelInt.ToString();
            }

        }

        // Use jetpack when holding finger down
        if (Input.touches.Length > 0)
        {
            if (fuel > 0)
            {
                rb2d.AddForce(Vector3.up * 5f);
                fuel -= 0.1f;
                fuelInt = (int)fuel;
                fuelText.text = fuelInt.ToString();
            }

        }



        //collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 2000f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(moveInput * speed, rb2d.velocity.y); //Keyboard Input
        //rb2d.velocity = new Vector2(Input.acceleration.x * speed, rb2d.velocity.y); // Accelerometer + Gyroscope
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.StartsWith("JetPack"))
        {
            fuel = 100f;
            //fuelInt = (int)fuel;
            fuelText.text = fuel.ToString();



            Destroy(collision.gameObject);

        }
    }

}
