using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStones : MonoBehaviour
{
    [SerializeField] private GameObject obj0, obj1, obj2;
    float RandX;
    Vector2 whereToSpawn;
    [SerializeField] private float spawnRate = 20f;
    float nextSpawn = 5.0f;
    [SerializeField] private Transform[] target;
    private int idStone = 0;

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            RandX = Random.Range(-4f, 4f);
            whereToSpawn = new Vector2(RandX, target[PlayerPrefs.GetInt("skin")].transform.position.y + 14);
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

        if ((int)target[PlayerPrefs.GetInt("skin")].transform.position.y % 50 == 0 && target[PlayerPrefs.GetInt("skin")].transform.position.y > 25)
        {
            if (spawnRate > 10f)
            {
                spawnRate -= 0.04f;
            }
            else
            {
                spawnRate = 10f;
            }
            Debug.Log("Stone:" + spawnRate);
        }
    }

    private int RandomStone()
    {
        int stoneId = Random.Range(1, 101);
        return stoneId;
    }
}