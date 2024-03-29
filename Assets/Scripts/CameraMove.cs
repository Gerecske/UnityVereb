using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float FlowSpeed = 2f;
    public Transform target;

    // A kamera kövesse a célpontot az előre beállított sebességgel
    void Update()
    {
        Vector3 newPos = new Vector3(target.position.x,target.position.y,-10f);
        transform.position = Vector3.Slerp(transform.position,newPos,FlowSpeed*Time.deltaTime);
    }
}
