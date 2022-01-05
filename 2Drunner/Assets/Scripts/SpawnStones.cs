using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStones : MonoBehaviour
{
    [SerializeField] private GameObject obj0, obj1, obj2;
    float RandX;
    Vector2 whereToSpawn;
    [SerializeField] private float spawnRate;
    float nextSpawn = 5.0f;
    [SerializeField] private Transform[] target;
    private int idStone = 0;
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
            if (spawnRate > 8f)
            {
                spawnRate -= 0.045f;
            }
            else
            {
                spawnRate = 8f;
            }
        }
    }

    public void StartPosition()
    {
        RandX = Random.Range(-4f, 4f);
        whereToSpawn = new Vector2(RandX, target[PlayerPrefs.GetInt("skin")].transform.position.y + 14);

        check = CheckSpawnPoint(whereToSpawn);
        if (check)
        {
            idStone = RandomStone();
            if (idStone <= 55)
            {
                Instantiate(obj0, whereToSpawn, Quaternion.identity);
            }
            else if (idStone > 55 && idStone <= 85)
            {
                Instantiate(obj1, whereToSpawn, Quaternion.identity);
            }
            else
            {
                Instantiate(obj2, whereToSpawn, Quaternion.identity);
            }
        }
        else
        {
            //StartPosition();
        }
    }

    bool CheckSpawnPoint(Vector2 spawnposition)
    {
        colliders = Physics2D.OverlapCircleAll(spawnposition, 1.2f);
        if (colliders.Length > 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    private int RandomStone()
    {
        int stoneId = Random.Range(1, 101);
        return stoneId;
    }
}