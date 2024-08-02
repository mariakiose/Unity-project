using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniobjects : MonoBehaviour
{
    public GameObject minicube;
    public GameObject minisphere;
    public GameObject minicylinder;
    private int objectToGenerate;
    private int radius;
   
    
   


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           
            radius = Random.Range(1, 11);
            objectToGenerate = Random.Range(1, 4);

            if (objectToGenerate == 1)
             {
                var obj =Instantiate(minicube);
                obj.transform.localScale = new Vector3(radius, radius, radius);
                obj.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
                obj.transform.Translate(0, 0, 0);
                obj.GetComponent<randomMove>().takeRadius = radius / 2;
                
            }
             if (objectToGenerate == 2)
             {
                var obj=Instantiate(minisphere);
                obj.transform.localScale = new Vector3(radius, radius, radius);
                obj.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
                obj.transform.Translate(0, 0, 0);
                obj.GetComponent<randomMove>().takeRadius = radius / 2;

            }
             if (objectToGenerate == 3)
             {
                var obj=Instantiate(minicylinder);
                obj.transform.localScale = new Vector3(radius, radius /2, radius);
                obj.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
                obj.transform.Translate(0, 0, 0);
                obj.GetComponent<randomMove>().takeRadius = radius / 2;

            }
            
        }
    }
}
