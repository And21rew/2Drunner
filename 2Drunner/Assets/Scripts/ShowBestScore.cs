using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowBestScore : MonoBehaviour
{
    [SerializeField] private Text score;
    [SerializeField] private Text coin;

    void Start()
    {
        score.text = "You best score:" + "\n" + PlayerPrefs.GetInt("score").ToString();
        coin.text = "You have:" + PlayerPrefs.GetInt("coin").ToString() + "coin";
    }

    void Update()
    {
        score.text = "You best score:" + "\n" + PlayerPrefs.GetInt("score").ToString();
        coin.text = "You have:" + "\n" + PlayerPrefs.GetInt("coin").ToString() + " coin";
    }
}
