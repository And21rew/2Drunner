using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    public Rigidbody2D rb;
    public UIButtonInfo buttonA;
    public UIButtonInfo buttonD;
    //public Touch touch = Input.GetTouch(0);

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
    }

    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);

        if (Input.GetAxis("Horizontal") > 0 && this.gameObject.transform.position.x < 2.65)
        //if (buttonD.isDown && this.gameObject.transform.position.x < 2.65)
        //if (touch.position.x > Screen.width / 2)
        {
            transform.Translate(Vector2.right * 2 * speed * Time.deltaTime);
        }

        if (Input.GetAxis("Horizontal") < 0 && this.gameObject.transform.position.x > -2.65)
        //if (buttonA.isDown && this.gameObject.transform.position.x > -2.65)
        //if (touch.position.x < Screen.width / 2)
        {
            transform.Translate(Vector2.left * 2 * speed * Time.deltaTime);
        }
    }
    /*
    public void ButtonLeft()
    {
        if (this.gameObject.transform.position.x > -2.65)
        {
            transform.Translate(Vector2.left * 2 * speed * Time.deltaTime);
        }
    }

    public void ButtonRight()
    {
        if (this.gameObject.transform.position.x < 2.65)
        {
            transform.Translate(Vector2.right * 2 * speed * Time.deltaTime);
        }
    }
    */
}
