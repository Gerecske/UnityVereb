using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            this.GetComponent<Renderer>().material.color = Color.green;
        }
        else
        {
            this.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
