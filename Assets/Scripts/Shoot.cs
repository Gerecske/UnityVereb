using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject ShootPrefab;
    private Rigidbody2D rb;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb = Instantiate(ShootPrefab,transform.position,transform.rotation).GetComponent<Rigidbody2D>();
        }
    }

}
