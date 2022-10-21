using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;
    public float speed = 20;
    private float movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        movement = Input.GetAxis("Horizontal");
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        backTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
        frontTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
        this.GetComponent<Rigidbody2D>().AddTorque(-movement * (speed*0.5f) * Time.fixedDeltaTime);
    }
}
