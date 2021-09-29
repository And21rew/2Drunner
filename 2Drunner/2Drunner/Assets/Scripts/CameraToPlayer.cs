using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraToPlayer : MonoBehaviour
{
    [SerializeField] private Transform target;
    readonly float speed = 8f;

    void Start()
    {
        transform.position = new Vector3(transform.position.x, target.transform.position.y + 5, transform.position.z);
    }

    void Update()
    {
        Vector3 position = target.position;
        position.x = transform.position.x;
        position.y = target.transform.position.y + 5;
        position.z = transform.position.z;
        transform.position = Vector3.Lerp(transform.position, position, speed * Time.deltaTime); 
    }
}