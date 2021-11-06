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

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            RandX = Random.Range(-4f, 4f);
            whereToSpawn = new Vector2(RandX, target[PlayerPrefs.GetInt("skin")].transform.position.y + 14);
            Instantiate(obj, whereToSpawn, Quaternion.identity);
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
}
