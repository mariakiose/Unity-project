using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    public float Speed = 15f;
    public GameObject sphere;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * Time.deltaTime * Speed, Space.World);

        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.up * Time.deltaTime * -Speed, Space.World);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * -Speed, Space.World);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * Speed, Space.World);
        }
        if ((Input.GetKey("[+]")) || (Input.GetKey(KeyCode.Equals)) )
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -Speed, Space.World);
        }
        if (Input.GetKey("-") || Input.GetKey("[-]"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Speed, Space.World);
        }

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, 15, 85);
        pos.y = Mathf.Clamp(pos.y, 15, 85);
        pos.z = Mathf.Clamp(pos.z, 15, 85);
        transform.position = pos;


    }
}
