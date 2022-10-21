using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject ShootPrefab;
    private Rigidbody2D rb;

    // Lövedék kilövése a gomb megnyomásakor
    public void ShootBullet()
    {
        rb = Instantiate(ShootPrefab, transform.position, transform.rotation).GetComponent<Rigidbody2D>();
    }

}
