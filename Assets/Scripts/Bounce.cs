using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    [SerializeField] private AudioClip bounceSound;
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

        if(collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 600f);
            sc.PlayOneShot(bounceSound);
             GameObject explosion = Instantiate(explosionFX, transform.position, transform.rotation);
            Destroy(explosion, explosionDuration);
        }
    }
}
