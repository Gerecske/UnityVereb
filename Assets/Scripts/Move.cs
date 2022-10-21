using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;
    public float speed = 20;
    private float movement;

    // Forgatónyomaték alkalmazása a kocsi kerekeire, hogy haladjon
    private void FixedUpdate()
    {
        backTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
        frontTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
        this.GetComponent<Rigidbody2D>().AddTorque(-movement * (speed*0.5f) * Time.fixedDeltaTime);
    }

    // Beellátjuk, hogy merre haladjon az autó - a függvények a képernyő gombjairól vannak meghívva
    public void Gas()
    {
        movement = 0.5f;
    }
    public void NoGas()
    {
        movement = 0;
    }
    public void Brake()
    {
        movement = -0.5f;
    }
}
