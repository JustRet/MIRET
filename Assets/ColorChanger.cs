using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Material m1;
    public Material m2;
    private bool b = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   public void changeColor()
    {
        if (b)
        {
            GetComponent<Renderer>().material = m1;
            b = false;
        }
        else
        {
            GetComponent<Renderer>().material = m2;
            b = true;
        }
    }
}
