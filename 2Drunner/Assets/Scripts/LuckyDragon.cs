using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LuckyDragon : MonoBehaviour
{
    [SerializeField] private GameObject warn, win, exit;
    [SerializeField] private GameObject[] locks;
    [SerializeField] private Text winText;
    private int randomDrop, randomDrac, idDrop, idDragon = 0;

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
            idDrop = Lucky();
            win.SetActive(true);
            exit.SetActive(false);
            if (idDrop <= 48)
            {
                PlayerPrefs.SetInt("coin", PlayerPrefs.GetInt("coin") + 5);
                winText.text = "You have 5 coins!";
            }
            else if (idDrop > 48 && idDrop < 98)
            {
                PlayerPrefs.SetInt("item0", PlayerPrefs.GetInt("item0") + 2);
                winText.text = "You have 2 not cleaned First Stones!";
            }
            else
            {
                idDragon = RandomDracon();
                if (idDragon < 81)
                {
                    PlayerPrefs.SetInt("LockDragon1", 1);
                    winText.text = "You have skin Rhino!";
                }
                else
                {
                    PlayerPrefs.SetInt("LockDragon2", 1);
                    winText.text = "You have skin Skeleton!";
                }
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
            idDrop = Lucky();
            win.SetActive(true);
            exit.SetActive(false);
            if (idDrop <= 31)
            {
                PlayerPrefs.SetInt("coin", PlayerPrefs.GetInt("coin") + 10);
                winText.text = "You have 10 coins!";
            }
            else if (idDrop > 31 && idDrop <= 62)
            {
                PlayerPrefs.SetInt("item0", PlayerPrefs.GetInt("item0") + 3);
                winText.text = "You have 3 not cleaned First Stones!";
            }
            else if (idDrop > 62 && idDrop <= 93)
            {
                PlayerPrefs.SetInt("item1", PlayerPrefs.GetInt("item1") + 2);
                winText.text = "You have 2 not cleaned Second Stones!";
            }
            else
            {
                idDragon = RandomDracon();
                if (idDragon <= 50)
                {
                    PlayerPrefs.SetInt("LockDragon1", 1);
                    winText.text = "You have skin Rhino!";
                }
                else if (idDragon > 50 && idDragon <= 90)
                {
                    PlayerPrefs.SetInt("LockDragon2", 1);
                    winText.text = "You have skin Skeleton!";
                }
                else
                {
                    PlayerPrefs.SetInt("LockDragon3", 1);
                    winText.text = "You have skin Dessert!";
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
            idDrop = Lucky();
            win.SetActive(true);
            exit.SetActive(false);
            if (idDrop <= 22)
            {
                PlayerPrefs.SetInt("coin", PlayerPrefs.GetInt("coin") + 20);
                winText.text = "You have 20 coins!";
            }
            else if (idDrop > 22 && idDrop <= 44)
            {
                PlayerPrefs.SetInt("item0", PlayerPrefs.GetInt("item0") + 4);
                winText.text = "You have 4 not cleaned First Stones!";
            }
            else if (idDrop > 44 && idDrop <= 66)
            {
                PlayerPrefs.SetInt("item1", PlayerPrefs.GetInt("item1") + 3);
                winText.text = "You have 3 not cleaned Second Stones!";
            }
            else if (idDrop > 66 && idDrop <= 88)
            {
                PlayerPrefs.SetInt("item2", PlayerPrefs.GetInt("item2") + 2);
                winText.text = "You have 2 not cleaned Third Stones!";
            }
            else
            {
                idDragon = RandomDracon();
                if (idDragon <= 40)
                {
                    PlayerPrefs.SetInt("LockDragon1", 1);
                    winText.text = "You have skin Rhino!";
                }
                else if (idDragon > 40 && idDragon <= 80)
                {
                    PlayerPrefs.SetInt("LockDragon2", 1);
                    winText.text = "You have skin Skeleton!";
                }
                else if (idDragon > 80 && idDragon <= 95)
                {
                    PlayerPrefs.SetInt("LockDragon3", 1);
                    winText.text = "You have skin Dessert!";
                }
                else
                {
                    PlayerPrefs.SetInt("LockDragon4", 1);
                    winText.text = "You have skin Lava!";
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
        randomDrop = Random.Range(1, 101);
        return randomDrop;
    }

    private int RandomDracon()
    {
        randomDrac = Random.Range(1, 101);
        return randomDrac;
    }
}
