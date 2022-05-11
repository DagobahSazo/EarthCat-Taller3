using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charchazo : MonoBehaviour
{
    public Rigidbody2D rb2d;
    Vector2 fuerzaCharchazo;
    public float minFuerza, maxFuerza;

    private void Start()
    {
        AplicarFuerza();
        Destroy(gameObject, 5);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
          
            Destroy(gameObject);
        }
    }
    
 

    public void AplicarFuerza()
    {
        fuerzaCharchazo.x = Random.Range(minFuerza, maxFuerza);
        rb2d.AddForce(fuerzaCharchazo, ForceMode2D.Impulse);
    }

}
