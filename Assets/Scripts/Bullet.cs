using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    private Rigidbody2D rb;
    
    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        
        // A lövedék haladjon jobbra az előre beállított sebességgel
        rb.velocity = transform.right * speed;
    }

    // Ha a lövedék találkozik egy objektummal, ami nem az autó törzse, törlődjön
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name != "Body")
        {
            Debug.Log(collision.name);
            Destroy(gameObject);
        }
    }
}
