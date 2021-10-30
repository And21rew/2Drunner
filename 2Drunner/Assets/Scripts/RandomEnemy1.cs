using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemy1 : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    float RandX;
    Vector2 whereToSpawn;
    [SerializeField] private float spawnRate = 5f;
    float nextSpawn = 0.0f;
    //[SerializeField] private Transform player;
    [SerializeField] private Transform[] target;

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            RandX = Random.Range(-5f, 5f);
            whereToSpawn = new Vector2(RandX, target[PlayerPrefs.GetInt("skin")].transform.position.y + 14);
            Instantiate(obj, whereToSpawn, Quaternion.identity);
        }
    }
}
