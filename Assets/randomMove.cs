using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomMove : MonoBehaviour
{
    public GameObject sphere;
    private GameObject cube;
    public float takeRadius;
    private Vector3 myDirection;
    private float newspeed;
   


    // Start is called before the first frame update
    void Start()
    {
        myDirection = new Vector3(Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f));
        cube = GameObject.FindGameObjectWithTag("cube");
    }

    // Update is called once per frame
    void Update()
    {
        newspeed = cube.GetComponent<moveFaster>().speed;
        Vector3 pos = transform.position;
        pos += myDirection * Time.deltaTime * newspeed;
        pos.x = Mathf.Clamp(pos.x, takeRadius, 100 - takeRadius);
        pos.z = Mathf.Clamp(pos.z, takeRadius, 100 - takeRadius);
        pos.y = Mathf.Clamp(pos.y, takeRadius, 100 - takeRadius);
        if (pos.x == 100 - takeRadius || pos.x == takeRadius)
        {
            myDirection.x = -myDirection.x;
        }
        if (pos.y == 100 - takeRadius || pos.y == takeRadius)
        {
            myDirection.y = -myDirection.y;
        }
        if (pos.z == 100 - takeRadius || pos.z == takeRadius)
        {
            myDirection.z = -myDirection.z;
        }


        if (pos.x - takeRadius <= sphere.transform.position.x + 15 &&
            pos.x + takeRadius >= sphere.transform.position.x - 15 &&
            pos.y - takeRadius <= sphere.transform.position.y + 15 &&
            pos.y + takeRadius >= sphere.transform.position.y - 15 &&
            pos.z - takeRadius <= sphere.transform.position.z + 15 &&
            pos.z + takeRadius >= sphere.transform.position.z - 15)
        {
            myDirection.x = -myDirection.x;
            myDirection.y = -myDirection.y;
            myDirection.z = -myDirection.z;
        }

        transform.position = pos;
       

    }
}
