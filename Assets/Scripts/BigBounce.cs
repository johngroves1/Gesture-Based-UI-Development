using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBounce : MonoBehaviour
{
    [SerializeField] private AudioClip bigBounceSound;
    [SerializeField] private GameObject bigBounceFX;
    private float explosionDuration = 1.0f;
    // Start is called before the first frame update

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
