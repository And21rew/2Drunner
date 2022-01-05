using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] private Text[] count;
    [SerializeField] private Text[] countInMaterial;
    [SerializeField] private Text[] countInSkin;
    private int maxBonus;
    [SerializeField] private Button[] items;
    [SerializeField] private GameObject[] itemsAnim;
    [SerializeField] private AudioSource coin;
    [SerializeField] private AudioClip clipCoin;

    void Start()
    {
        maxBonus = PlayerPrefs.GetInt("maxbonus");
    }

    void Update()
    {
        for (int i = 0; i < count.Length; i++)
        {
            count[i].text = PlayerPrefs.GetInt("item" + i.ToString()).ToString();
            countInMaterial[i].text = PlayerPrefs.GetInt("item" + i.ToString()).ToString(); ;
        }

        for (int i = 0; i < countInSkin.Length; i++)
        {
            countInSkin[i].text = PlayerPrefs.GetInt("item" + (i + 3).ToString()).ToString();
        }
    }

    public void BuyItem0(int cost)
    {
        if (PlayerPrefs.GetInt("coin") >= cost)
        {
            StartCoroutine(ItemAnimation(0));
            PlayerPrefs.SetInt("item0", PlayerPrefs.GetInt("item0") + 1);
            PlayerPrefs.SetInt("coin", PlayerPrefs.GetInt("coin") - cost);
        }
    }

    public void BuyItem1(int cost)
    {
        if (PlayerPrefs.GetInt("coin") >= cost)
        {
            StartCoroutine(ItemAnimation(1));
            PlayerPrefs.SetInt("item1", PlayerPrefs.GetInt("item1") + 1);
            PlayerPrefs.SetInt("coin", PlayerPrefs.GetInt("coin") - cost);
        }
    }

    public void BuyItem2(int cost)
    {
        if (PlayerPrefs.GetInt("coin") >= cost)
        {
            StartCoroutine(ItemAnimation(2));
            PlayerPrefs.SetInt("item2", PlayerPrefs.GetInt("item2") + 1);
            PlayerPrefs.SetInt("coin", PlayerPrefs.GetInt("coin") - cost);
        }
    }

    public void BuyItem3(int cost)
    {
        if (PlayerPrefs.GetInt("coin") >= cost)
        {
            StartCoroutine(ItemAnimation(3));
            PlayerPrefs.SetInt("item3", PlayerPrefs.GetInt("item3") + 1);
            PlayerPrefs.SetInt("coin", PlayerPrefs.GetInt("coin") - cost);
        }
    }

    public void BuyItem4(int cost)
    {
        if (PlayerPrefs.GetInt("coin") >= cost)
        {
            StartCoroutine(ItemAnimation(4));
            PlayerPrefs.SetInt("item4", PlayerPrefs.GetInt("item4") + 1);
            PlayerPrefs.SetInt("coin", PlayerPrefs.GetInt("coin") - cost);
        }
    }

    public void BuyItem5(int cost)
    {
        if (PlayerPrefs.GetInt("coin") >= cost)
        {
            StartCoroutine(ItemAnimation(5));
            PlayerPrefs.SetInt("item5", PlayerPrefs.GetInt("item5") + 1);
            PlayerPrefs.SetInt("coin", PlayerPrefs.GetInt("coin") - cost);
        }
    }

    IEnumerator ItemAnimation(int id)
    {
        coin.PlayOneShot(clipCoin);
        items[id].interactable = false;
        itemsAnim[id].SetActive(true);
        yield return new WaitForSeconds(1f);
        itemsAnim[id].SetActive(false);
        items[id].interactable = true;
    }
}
