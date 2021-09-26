using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);

        if (Input.GetAxis("Horizontal") > 0)
            transform.Translate(Vector2.right * speed * Time.deltaTime);

        if (Input.GetAxis("Horizontal") < 0)
            transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
