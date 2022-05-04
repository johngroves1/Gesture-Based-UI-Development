using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBounce : MonoBehaviour
{
    [SerializeField] private AudioClip bigBounceSound;
    [SerializeField] private GameObject explosionFX;
    private float explosionDuration = 1.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SoundController sc = FindObjectOfType<SoundController>();

        if (collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 1000f);
            sc.PlayOneShot(bigBounceSound);
            GameObject explosion = Instantiate(explosionFX, transform.position, transform.rotation);
            Destroy(explosion, explosionDuration);
        }
    }
}
