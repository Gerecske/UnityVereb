using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject car;
    public Transform spawn1;
    public Transform spawn2;
    public Transform spawn3;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "flag1")
        {
            car.transform.position = spawn2.position;
        }
        else if (collision.name == "flag2")
        {
            car.transform.position = spawn3.position;
        }
        else if (collision.name == "flag3")
        {
            car.transform.position = spawn1.position;
        }
    }
}
