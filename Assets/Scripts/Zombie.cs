using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public Animator animator;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Bullet(Clone)")
        {
            animator.SetBool("dead", true);
            Invoke("Die", 0.55f);
            
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }

    
}
