﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float speed=12f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * Time.deltaTime * -speed, Space.World);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * -speed, Space.World);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World);
        }

        if (Input.GetKey(KeyCode.G))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -speed, Space.World);
        }
        if (Input.GetKey(KeyCode.H))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World);
        }
    }
}
