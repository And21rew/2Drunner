using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraToPlayer : MonoBehaviour
{
    [SerializeField] private Transform [] target;
    readonly float speed = 8f;

    void Start()
    {
        //if (PlayerPrefs.GetInt("skin") == 0)
            transform.position = new Vector3(transform.position.x, target[PlayerPrefs.GetInt("skin")].transform.position.y + 2, transform.position.z);

        //if (PlayerPrefs.GetInt("skin") == 1)
            //transform.position = new Vector3(transform.position.x, target[PlayerPrefs.GetInt("skin")].transform.position.y + 2, transform.position.z);
    }

    void Update()
    {
        Vector3 position = new Vector3(transform.position.x, target[PlayerPrefs.GetInt("skin")].transform.position.y + 2, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, position, speed * Time.deltaTime); 
    }
}