using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;
    public Transform bT;
    public Transform fT;
    public float speed = 20f;
    private float movement;
    private float bx;
    private float fx;

    private void Start()
    {
        bx = bT.position.x;
        fx = fT.position.x;
    }
    // Update is called once per frame
    void Update()
    {
        //movement = Input.GetAxis("Horizontal");
        bT.position = new Vector3(bx, 0, 0);
        fT.position = new Vector3(fx, 0, 0);
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
