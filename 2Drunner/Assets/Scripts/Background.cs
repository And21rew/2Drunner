using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField] private GameObject cam;
    [SerializeField] private float parallaxEffect;
    float length, startposition;

    void Start()
    {
        startposition = transform.position.y;
        length = GetComponent<SpriteRenderer>().bounds.size.y;
    }

    void FixedUpdate()
    {
        float temp = cam.transform.position.y * (1 - parallaxEffect);
        float dist = cam.transform.position.y * parallaxEffect;
        transform.position = new Vector3(transform.position.x, startposition + dist, transform.position.z);
        if (temp > startposition + length)
            startposition += length;
        else if (temp < startposition - length)
            startposition -= length;
    }
}
