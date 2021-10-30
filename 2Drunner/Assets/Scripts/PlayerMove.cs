using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    public Rigidbody2D rb;

    bool FacingRight = true;
    int directionInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
    }

    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.up);
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(speed * directionInput, rb.velocity.y);

        if (directionInput < 0 && FacingRight)
        {
            Flip();
        }
        else if (directionInput > 0 && !FacingRight)
        {
            Flip();
        }
    }

    public void Move(int InputAxis)
    {
        directionInput = 2 * InputAxis;
    }

    void Flip()
    {
        FacingRight = !FacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
