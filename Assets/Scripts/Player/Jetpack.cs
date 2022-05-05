using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jetpack : MonoBehaviour
{
    [SerializeField] private AudioClip Sound;
    [SerializeField] private GameObject pickupFX;
    private float explosionDuration = 1.0f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SoundController sc = FindObjectOfType<SoundController>();

        sc.PlayOneShot(Sound);
        GameObject explosion = Instantiate(pickupFX, transform.position, transform.rotation);
        Destroy(explosion, explosionDuration);
    }
}
