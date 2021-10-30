using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinInGame : MonoBehaviour
{
    [SerializeField] private GameObject[] players;
    
    void Start()
    {
        if (PlayerPrefs.GetInt("skin") == 0)
        {
            players[0].SetActive(true);
        }

        if (PlayerPrefs.GetInt("skin") == 1)
        {
            players[1].SetActive(true);
        }
    }
}
