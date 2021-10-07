using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowBestScore : MonoBehaviour
{
    [SerializeField] private Text score;

    void Start()
    {
        score.text = "You best score:" + "\n" + PlayerPrefs.GetInt("score").ToString();
    }

    void Update()
    {
        score.text = "You best score:" + "\n" + PlayerPrefs.GetInt("score").ToString();
    }
}
