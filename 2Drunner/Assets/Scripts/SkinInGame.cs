using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinInGame : MonoBehaviour
{
    [SerializeField] private GameObject[] players;
    [SerializeField] private GameObject[] leftButton;
    [SerializeField] private GameObject[] rightButton;

    void Start()
    {
        players[PlayerPrefs.GetInt("skin")].SetActive(true);
        leftButton[PlayerPrefs.GetInt("skin")].SetActive(true);
        rightButton[PlayerPrefs.GetInt("skin")].SetActive(true);
    }
}
