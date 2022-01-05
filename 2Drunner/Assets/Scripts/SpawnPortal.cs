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
    bool check;
    public Collider2D[] colliders;

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            StartPosition();
        }
    }

    public void StartPosition()
    {
        whereToSpawn = new Vector2(RandX, target[PlayerPrefs.GetInt("skin")].transform.position.y + 14);

        check = CheckSpawnPoint(whereToSpawn);
        if (check)
        {
            Instantiate(portal, whereToSpawn, Quaternion.identity);
        }
        else
        {
            //StartPosition();
        }
    }

    bool CheckSpawnPoint(Vector2 spawnposition)
    {
        colliders = Physics2D.OverlapCircleAll(spawnposition, 2f);
        if (colliders.Length > 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
