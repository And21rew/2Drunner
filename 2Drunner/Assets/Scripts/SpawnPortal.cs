using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPortal : MonoBehaviour
{
    [SerializeField] private GameObject portal;
    float RandX = 0;
    Vector2 whereToSpawn;
    [SerializeField] private float spawnRate = 30f;
    float nextSpawn = 30.0f;
    [SerializeField] private Transform[] target;

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            whereToSpawn = new Vector2(RandX, target[PlayerPrefs.GetInt("skin")].transform.position.y + 14);
            Instantiate(portal, whereToSpawn, Quaternion.identity);
        }
    }
}
