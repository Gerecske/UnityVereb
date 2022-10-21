using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public Animator animator;
    public int lifes = 3;

    // Egy zombinak 3 élete van. Ha eltalálja egy lövedék, elveszít egyet. Ha kifogy az életekből, "meghal"
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Bullet(Clone)")
        {
            lifes--;
            if (lifes <= 0)
            {
                animator.SetBool("dead", true);
                Invoke("Die", 0.55f);
            }
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }

    
}
