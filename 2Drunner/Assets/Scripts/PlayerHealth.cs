using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    private int health;
    [SerializeField] private GameObject[] notActiveObjects;
    [SerializeField] private GameObject gameoverScreen;

    void Start()
    {
        health = PlayerPrefs.GetInt("health");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            health--;

            if (health <= 0)
            {
                Time.timeScale = 0;
                gameoverScreen.SetActive(true);
                for(int i = 0; i < notActiveObjects.Length; i++)
                {
                    notActiveObjects[i].SetActive(false);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            PlayerPrefs.SetInt("coin", PlayerPrefs.GetInt("coin") + 1);
        }
    }
}
