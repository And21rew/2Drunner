using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text score;
    [SerializeField] private Text finalScore;
    [SerializeField] private Text coin;
    [SerializeField] private Transform[] player;
    private int scores;

    void Start()
    {
        score.text = "Score: 0";
        coin.text = "Coin: " + PlayerPrefs.GetInt("coin");
    }

    void Update()
    {
        if (player[PlayerPrefs.GetInt("skin")].transform.position.y > 0)
        {
            scores = (int)player[PlayerPrefs.GetInt("skin")].transform.position.y;
            score.text = "Score: " + scores.ToString();
            finalScore.text = "You score: " + scores.ToString() + "\n" + "Retry?";

            if (scores > PlayerPrefs.GetInt("score"))
                PlayerPrefs.SetInt("score", scores);
        }

        coin.text = "Coin: " + PlayerPrefs.GetInt("coin");
    }
}
