using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jetpack : MonoBehaviour
{
    [SerializeField] private AudioClip Sound;
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


        sc.PlayOneShot(Sound);
        GameObject explosion = Instantiate(explosionFX, transform.position, transform.rotation);
        Destroy(explosion, explosionDuration);
    }
}
