using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;
    public float speed = 20f;
    private float movement;

    // Update is called once per frame
    void Update()
    {
        //movement = Input.GetAxis("Horizontal");
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        backTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
        frontTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
        Debug.Log(movement);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("Flag"))
            Debug.Log("Nyertél!!4!44");
    }

    public void Gas()
    {
        movement = 1;
    }
    public void NoGas()
    {
        movement = 0;
    }
}
