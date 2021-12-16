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
        score.text = "Best score:" + "\n" + PlayerPrefs.GetInt("score").ToString();
        coin.text = PlayerPrefs.GetInt("coin").ToString();
        coinInShop.text = PlayerPrefs.GetInt("coin").ToString();
    }

    void Update()
    {
        score.text = "Best score:" + "\n" + PlayerPrefs.GetInt("score").ToString();
        coin.text = PlayerPrefs.GetInt("coin").ToString();
        coinInShop.text = PlayerPrefs.GetInt("coin").ToString();
    }
}
