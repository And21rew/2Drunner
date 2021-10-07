using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text score;
    [SerializeField] private Text finalScore;
    [SerializeField] private Transform player;
    private int scores;

    void Start()
    {
        score.text = "Score: 0";
    }

    void Update()
    {
        if (player.transform.position.y > 0)
        {
            scores = (int)player.transform.position.y;
            score.text = "Score: " + scores.ToString();
            finalScore.text = "You score: " + scores.ToString() + "\n" + "Retry?";

            if (scores > PlayerPrefs.GetInt("score"))
                PlayerPrefs.SetInt("score", scores);
        }
    }
}
