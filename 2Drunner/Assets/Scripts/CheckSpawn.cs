using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSpawn : MonoBehaviour
{
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Item0"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Item1"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Item2"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("portal"))
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Item0"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Item1"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Item2"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("portal"))
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Item0"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Item1"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Item2"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("portal"))
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Item0"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Item1"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Item2"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("portal"))
        {
            Destroy(gameObject);
        }
    }
}
