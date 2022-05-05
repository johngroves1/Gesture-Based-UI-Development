﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchScale : MonoBehaviour
{
    public float width = 1;
    public float height = 1;
    public Vector3 position = new Vector3(10, 5, 0);

    public PinchScaleController pinch;

    void Awake()
    {
        // set the scaling
        Vector3 scale = new Vector3(width, height, 1f);
        transform.localScale = scale;
        // set the position
        //transform.position = position;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
