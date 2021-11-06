using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LuckyDragon : MonoBehaviour
{
    [SerializeField] private GameObject warn, win, exit;
    [SerializeField] private GameObject[] locks;
    [SerializeField] private Text winText;
    private int numberItem = 0;
    private int randomDrop, randomDrac = 0;

    void Start()
    {
        //PlayerPrefs.SetInt("coin", 500000);
        Debug.Log(PlayerPrefs.GetInt("LockDragon0"));
        Debug.Log(PlayerPrefs.GetInt("LockDragon1"));
        Debug.Log(PlayerPrefs.GetInt("LockDragon2"));
        Debug.Log(PlayerPrefs.GetInt("LockDragon3"));
        Debug.Log(PlayerPrefs.GetInt("LockDragon4"));
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("LockDragon0") == 1)
        {
            locks[0].SetActive(false);
        }

        if (PlayerPrefs.GetInt("LockDragon1") == 1)
        {
            locks[1].SetActive(false);
        }

        if (PlayerPrefs.GetInt("LockDragon2") == 1)
        {
            locks[2].SetActive(false);
        }

        if (PlayerPrefs.GetInt("LockDragon3") == 1)
        {
            locks[3].SetActive(false);
        }

        if (PlayerPrefs.GetInt("LockDragon4") == 1)
        {
            locks[4].SetActive(false);
        }
    }

    public void UseItem3()
    {
        if (PlayerPrefs.GetInt("item3") > 0)
        {
            PlayerPrefs.SetInt("item3", PlayerPrefs.GetInt("item3") - 1);
            numberItem = 1;
            int idDrop = Lucky();
            win.SetActive(true);
            exit.SetActive(false);
            if (idDrop <= 50)
            {
                PlayerPrefs.SetInt("coin", PlayerPrefs.GetInt("coin") + 5);
                winText.text = "You have 5 coins!";
            }
            else
            {
                PlayerPrefs.SetInt("item0", PlayerPrefs.GetInt("item0") + 2);
                winText.text = "You have 2 not cleaned item0!";
            }
        }
        else
        {
            StartCoroutine(ShowWarn());
        }
    }

    public void UseItem4()
    {
        if (PlayerPrefs.GetInt("item4") > 0)
        {
            PlayerPrefs.SetInt("item4", PlayerPrefs.GetInt("item4") - 1);
            numberItem = 2;
            int idDrop = Lucky();
            win.SetActive(true);
            exit.SetActive(false);
            if (idDrop <= 50)
            {
                PlayerPrefs.SetInt("coin", PlayerPrefs.GetInt("coin") + 10);
                winText.text = "You have 10 coins!";
            }
            else if (idDrop > 50 && idDrop <= 100)
            {
                PlayerPrefs.SetInt("item0", PlayerPrefs.GetInt("item0") + 3);
                winText.text = "You have 3 not cleaned item0!";
            }
            else if (idDrop > 100 && idDrop <= 150)
            {
                PlayerPrefs.SetInt("item1", PlayerPrefs.GetInt("item1") + 2);
                winText.text = "You have 2 not cleaned item1!";
            }
            else
            {
                numberItem = 2;
                int idDragon = RandomDracon();
                if (idDragon <= 50)
                {
                    PlayerPrefs.SetInt("LockDragon1", 1);
                    winText.text = "You have skin1!";
                }
                else if (idDragon > 50 && idDragon <= 90)
                {
                    PlayerPrefs.SetInt("LockDragon2", 1);
                    winText.text = "You have skin2!";
                }
                else
                {
                    PlayerPrefs.SetInt("LockDragon3", 1);
                    winText.text = "You have skin3!";
                }
            }
        }
        else
        {
            StartCoroutine(ShowWarn());
        }
    }

    public void UseItem5()
    {
        if (PlayerPrefs.GetInt("item5") > 0)
        {
            PlayerPrefs.SetInt("item5", PlayerPrefs.GetInt("item5") - 1);
            numberItem = 3;
            int idDrop = Lucky();
            win.SetActive(true);
            exit.SetActive(false);
            if (idDrop <= 50)
            {
                PlayerPrefs.SetInt("coin", PlayerPrefs.GetInt("coin") + 20);
                winText.text = "You have 20 coins!";
            }
            else if (idDrop > 50 && idDrop <= 100)
            {
                PlayerPrefs.SetInt("item0", PlayerPrefs.GetInt("item0") + 4);
                winText.text = "You have 4 not cleaned item0!";
            }
            else if (idDrop > 100 && idDrop <= 150)
            {
                PlayerPrefs.SetInt("item1", PlayerPrefs.GetInt("item1") + 3);
                winText.text = "You have 3 not cleaned item1!";
            }
            else if (idDrop > 150 && idDrop <= 200)
            {
                PlayerPrefs.SetInt("item2", PlayerPrefs.GetInt("item2") + 2);
                winText.text = "You have 2 not cleaned item2!";
            }
            else
            {
                numberItem = 3;
                int idDragon = RandomDracon();
                if (idDragon <= 100)
                {
                    PlayerPrefs.SetInt("LockDragon1", 1);
                    winText.text = "You have skin1!";
                }
                else if (idDragon > 100 && idDragon <= 150)
                {
                    PlayerPrefs.SetInt("LockDragon2", 1);
                    winText.text = "You have skin2!";
                }
                else if (idDragon > 150 && idDragon <= 190)
                {
                    PlayerPrefs.SetInt("LockDragon3", 1);
                    winText.text = "You have skin3!";
                }
                else
                {
                    PlayerPrefs.SetInt("LockDragon4", 1);
                    winText.text = "You have skin4!";
                }
            }
        }
        else
        {
            StartCoroutine(ShowWarn());
        }
    }

    IEnumerator ShowWarn()
    {
        warn.SetActive(true);
        yield return new WaitForSeconds(3f);
        warn.SetActive(false);
    }

    private int Lucky()
    {
        if (numberItem == 1)
        {
            numberItem = 0;
            randomDrop = Random.Range(1, 101);
            return randomDrop;
        }
        else if (numberItem == 2)
        {
            numberItem = 0;
            randomDrop = Random.Range(1, 161);
            return randomDrop;
        }
        else if (numberItem == 3)
        {
            numberItem = 0;
            randomDrop = Random.Range(1, 226);
            return randomDrop;
        }
        else
        {
            numberItem = 0;
            Debug.Log("exception");
            return 0;
        }
    }

    private int RandomDracon()
    {
        if (numberItem == 2)
        {
            numberItem = 0;
            randomDrac = Random.Range(1, 101);
            return randomDrac;
        }
        else if (numberItem == 3)
        {
            numberItem = 0;
            randomDrac = Random.Range(1, 201);
            return randomDrac;
        }
        else
        {
            numberItem = 0;
            Debug.Log("exception");
            return 0;
        }
    }
}
