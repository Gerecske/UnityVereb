using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;
    public float speed = 20f;
    private float movement;

    // Start is called before the first frame update
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        frontTire.AddTorque((60 * speed * Time.fixedDeltaTime) * -1);
        backTire.AddTorque((60 * speed * Time.fixedDeltaTime) * -1);
    }
}
