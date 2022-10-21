using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;
    public float speed = 20;
    private float movement;

    // Forgat�nyomat�k alkalm�z�sa a kocsi kerekeire, hogy haladjon
    private void FixedUpdate()
    {
        backTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
        frontTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
        this.GetComponent<Rigidbody2D>().AddTorque(-movement * (speed*0.5f) * Time.fixedDeltaTime);
    }

    // Be�ll�tj�k, hogy merre haladjon az aut� - a k�perny� gombjair�l vannak megh�vva
    public void Gass()
    {
        movement = 0.5f;
    }
    public void NoGass()
    {
        movement = 0;
    }
    public void Brake()
    {
        movement = -0.5f;
    }
}
