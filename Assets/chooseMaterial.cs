using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chooseMaterial : MonoBehaviour
{
    public Material red;
    public Material texture;
    public GameObject sphere;
    private bool flag;
    // Start is called before the first frame update
    void Start()
    {
        sphere.GetComponent<MeshRenderer>().material = red;
        flag = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (flag)
            {
                sphere.GetComponent<MeshRenderer>().material = texture;
                flag = false;
            }
            else
            {
                sphere.GetComponent<MeshRenderer>().material = red;
                flag = true;
            } 
           
        }

       
    }
}
