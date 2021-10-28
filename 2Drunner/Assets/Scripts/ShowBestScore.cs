using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowBestScore : MonoBehaviour
{
    [SerializeField] private Text score;
    [SerializeField] private Text coin;
    [SerializeField] private Text coinInShop;

    void Start()
    {
        score.text = "You best score:" + "\n" + PlayerPrefs.GetInt("score").ToString();
        coin.text = "You have:" + PlayerPrefs.GetInt("coin").ToString() + "coin";
        coinInShop.text = PlayerPrefs.GetInt("coin").ToString();
    }

    void Update()
    {
        score.text = "You best score:" + "\n" + PlayerPrefs.GetInt("score").ToString();
        coin.text = "You have:" + "\n" + PlayerPrefs.GetInt("coin").ToString() + " coin";
        coinInShop.text = PlayerPrefs.GetInt("coin").ToString();
    }
}
