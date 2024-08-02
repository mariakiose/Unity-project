using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveFaster : MonoBehaviour
{
    public float speed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Period) || Input.GetKey(KeyCode.Greater))
        {
            speed += 5.0f;
        }
        if (Input.GetKey(KeyCode.Comma) || Input.GetKey(KeyCode.Less))
        {
            speed -= 5.0f;
            if(speed <= 0)
            {
                speed = 0;
            }
        }
        
    }
}
