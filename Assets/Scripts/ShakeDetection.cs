using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class ShakeDetection : MonoBehaviour
{
    public Action OnShake;
    [SerializeField] private float shakeThreshold = 2.0f;
    private float accelerometerIntervals = 1.0f / 60.0f;
    private float lowPassSeconds = 1.0f;
    private float lowPassFilter;
    private Vector3 lowPassValue;

    private void Start()
    {
        //DontDestroyOnLoad(this.gameObject);

        lowPassFilter = accelerometerIntervals / lowPassSeconds;
        shakeThreshold *= shakeThreshold;
        lowPassValue = Input.acceleration;
    }
    private void Update()
    {
        Vector3 acceleration = Input.acceleration;
        lowPassValue = Vector3.Lerp(lowPassValue, acceleration, lowPassFilter);
        Vector3 deltaAcceleration = acceleration - lowPassValue;

        // Shake Detection
        if (deltaAcceleration.sqrMagnitude >= shakeThreshold)
            Debug.Log("Shake Detected");

    }
}
