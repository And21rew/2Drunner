using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    private int health;
    private int numberOfLocation;
    [SerializeField] private GameObject[] notActiveObjects;
    [SerializeField] private GameObject gameoverScreen;
    [SerializeField] private GameObject change;
    [SerializeField] private GameObject background;
    [SerializeField] private Sprite back1, back2, back3;

    void Start()
    {
        health = PlayerPrefs.GetInt("health");
        numberOfLocation = 1;
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

        if (collision.gameObject.CompareTag("Item0"))
        {
            Destroy(collision.gameObject);
            PlayerPrefs.SetInt("item0", PlayerPrefs.GetInt("item0") + 1);
        }

        if (collision.gameObject.CompareTag("Item1"))
        {
            Destroy(collision.gameObject);
            PlayerPrefs.SetInt("item1", PlayerPrefs.GetInt("item1") + 1);
        }

        if (collision.gameObject.CompareTag("Item2"))
        {
            Destroy(collision.gameObject);
            PlayerPrefs.SetInt("item2", PlayerPrefs.GetInt("item2") + 1);
        }

        if (collision.gameObject.CompareTag("portal"))
        {
            Destroy(collision.gameObject);
            StartCoroutine(ChangeLoc());
        }
    }

    IEnumerator ChangeLoc()
    {
        int randomBack = 0;
        change.SetActive(true);
        if (numberOfLocation == 1)
        {
            randomBack = Random.Range(1, 11);
            yield return new WaitForSeconds(1f);
            if (randomBack <= 5)
            {
                background.GetComponent<SpriteRenderer>().sprite = back2;
                numberOfLocation = 2;
            }
            else
            {
                background.GetComponent<SpriteRenderer>().sprite = back3;
                numberOfLocation = 3;
            }
            yield return new WaitForSeconds(1f);
            randomBack = 0;
            change.SetActive(false);
        }
        else if (numberOfLocation == 2)
        {
            randomBack = Random.Range(1, 11);
            yield return new WaitForSeconds(1f);
            if (randomBack <= 5)
            {
                background.GetComponent<SpriteRenderer>().sprite = back1;
                numberOfLocation = 1;
            }
            else
            {
                background.GetComponent<SpriteRenderer>().sprite = back3;
                numberOfLocation = 3;
            }
            yield return new WaitForSeconds(1f);
            randomBack = 0;
            change.SetActive(false);
        }
        else if (numberOfLocation == 3)
        {
            randomBack = Random.Range(1, 11);
            yield return new WaitForSeconds(1f);
            if (randomBack <= 5)
            {
                background.GetComponent<SpriteRenderer>().sprite = back1;
                numberOfLocation = 1;
            }
            else
            {
                background.GetComponent<SpriteRenderer>().sprite = back2;
                numberOfLocation = 2;
            }
            yield return new WaitForSeconds(1f);
            randomBack = 0;
            change.SetActive(false);
        }
        else
        {
            Debug.Log("Exception");
        }
    }
}
