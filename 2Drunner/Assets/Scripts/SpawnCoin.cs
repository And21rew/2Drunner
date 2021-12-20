using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    float RandX;
    Vector2 whereToSpawn;
    [SerializeField] private float spawnRate = 12f;
    float nextSpawn = 2.0f;
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

        if ((int)target[PlayerPrefs.GetInt("skin")].transform.position.y % 50 == 0 && target[PlayerPrefs.GetInt("skin")].transform.position.y > 25)
        {
            if (spawnRate > 5f)
            {
                spawnRate -= 0.04f;
            }
            else
            {
                spawnRate = 5f;
            }
            Debug.Log("Coin:" + spawnRate);
        }
    }

    public void StartPosition()
    {
        RandX = Random.Range(-4f, 4f);
        whereToSpawn = new Vector2(RandX, target[PlayerPrefs.GetInt("skin")].transform.position.y + 14);

        check = CheckSpawnPoint(whereToSpawn);
        if (check)
        {
            Instantiate(obj, whereToSpawn, Quaternion.identity);
        }
        else
        {
            //StartPosition();
        }
    }

    bool CheckSpawnPoint(Vector2 spawnposition)
    {
        colliders = Physics2D.OverlapCircleAll(spawnposition, 1.5f);
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