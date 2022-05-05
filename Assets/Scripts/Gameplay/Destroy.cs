using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject player;
    public GameObject platformPrefab;
    public GameObject springPrefab;
    private GameObject myPlatform;
    public GameObject jetpackPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If the collider hits a platform, 1 in 7 chance to spawn a bigbounce platform, otherwise spawn regular
        if (collision.gameObject.name.StartsWith("Platform"))
        {
            if (Random.Range(1, 7) == 1)
            {
                Destroy(collision.gameObject);
                Instantiate(springPrefab, new Vector2(Random.Range(-4.5f, 4.5f), player.transform.position.y + (10 + Random.Range(0.2f, .5f))), Quaternion.identity);
            }
            else
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-4.5f, 4.5f), player.transform.position.y + (10 + Random.Range(0.2f, .5f)));
            }
        }
        // If the collider hits a bigbounce platform, 1 in 7 chance to spawn another bigbounce platform, otherwise spawn regular
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
    }
}
