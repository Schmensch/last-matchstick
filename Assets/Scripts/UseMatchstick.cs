using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UseMatchstick : MonoBehaviour
{
    public int framesLit = 0;
    public Light light;

    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) {
            framesLit = 600;
        }

        if (framesLit > 0)
        {
            GetComponent<Light>().enabled = true;
            framesLit = framesLit - 1;
        }
        else
        {
            GetComponent<Light>().enabled = false;
        }
    }
}
