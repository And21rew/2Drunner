using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemy1 : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    float RandX;
    Vector2 whereToSpawn;
    [SerializeField] private float spawnRate = 2f;
    float nextSpawn = 0.0f;
    [SerializeField] private Transform player;

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            RandX = Random.Range(-5f, 5f);
            whereToSpawn = new Vector2(RandX, player.transform.position.y + 14);
            Instantiate(obj, whereToSpawn, Quaternion.identity);
        }
    }
}
