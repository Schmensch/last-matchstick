using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panic : MonoBehaviour
{

    public UseMatchstick usematchstick;
    public int PanicTimer = 600;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (usematchstick.framesLit < 1) {
            PanicTimer = PanicTimer - 1;
        }

        if (PanicTimer < 0) {
            Debug.Log("Youd died");
            Application.Quit();
        }
    }
}
