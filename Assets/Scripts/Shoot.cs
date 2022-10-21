using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject ShootPrefab;
    private Rigidbody2D rb;

    public void ShootB()
    {
        rb = Instantiate(ShootPrefab, transform.position, transform.rotation).GetComponent<Rigidbody2D>();
    }

}
