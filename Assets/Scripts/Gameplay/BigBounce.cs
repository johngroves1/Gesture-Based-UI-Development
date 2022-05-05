using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBounce : MonoBehaviour
{
    [SerializeField] private AudioClip bigBounceSound;
    [SerializeField] private GameObject bigBounceFX;
    private float explosionDuration = 1.0f;

    // If player collides with the big bounce pad, add an upwards force of 1000
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SoundController sc = FindObjectOfType<SoundController>();

        if (collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 1000f);
            sc.PlayOneShot(bigBounceSound);
            GameObject explosion = Instantiate(bigBounceFX, transform.position, transform.rotation);
            Destroy(explosion, explosionDuration);
        }
    }
}
