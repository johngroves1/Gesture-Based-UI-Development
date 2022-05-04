﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject player;
    public GameObject platformPrefab;
    public GameObject springPrefab;
    private GameObject myPlatform;
    public GameObject jetpackPrefab;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name.StartsWith("Platform"))
        {

            if (Random.Range(1, 7) == 1)
            {

                Destroy(collision.gameObject);
                Instantiate(springPrefab, new Vector2(Random.Range(-4.5f, 4.5f), player.transform.position.y + (10 + Random.Range(0.2f, .5f))), Quaternion.identity);


            }
            //Spawning jetpacks
            if (Random.Range(1, 20) == 1)
            {

                Destroy(collision.gameObject);
                Instantiate(jetpackPrefab, new Vector2(Random.Range(-4.5f, 4.5f), player.transform.position.y + (10 + Random.Range(0.2f, .5f))), Quaternion.identity);


            }
            else
            {

                collision.gameObject.transform.position = new Vector2(Random.Range(-4.5f, 4.5f), player.transform.position.y + (10 + Random.Range(0.2f, .5f)));

            }

        }
        else if (collision.gameObject.name.StartsWith("Spring"))
        {

            if (Random.Range(1, 7) == 1)
            {

                collision.gameObject.transform.position = new Vector2(Random.Range(-4.5f, 4.5f), player.transform.position.y + (10 + Random.Range(0.2f, .5f)));

            }
            else
            {

                Destroy(collision.gameObject);
                Instantiate(platformPrefab, new Vector2(Random.Range(-4.5f, 4.5f), player.transform.position.y + (10 + Random.Range(0.2f, .5f))), Quaternion.identity);


            }

        }



        // if(Random.Range(1, 6) > 1)
        // {
        //     myPlatform = (GameObject)Instantiate(platformPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (14 + Random.Range(0.5f, 1f))), Quaternion.identity);

        // } else
        // {
        //     myPlatform = (GameObject)Instantiate(springPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (14 + Random.Range(0.5f, 1f))), Quaternion.identity);

        // }

        // Destroy(collision.gameObject);

    }
}
