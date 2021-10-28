using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstStart : MonoBehaviour
{
    void Start()
    {
        if (!PlayerPrefs.HasKey("coin"))
        {
            PlayerPrefs.SetInt("coin", 0);
        }

        if (!PlayerPrefs.HasKey("score"))
        {
            PlayerPrefs.SetInt("score", 0);
        }

        if (!PlayerPrefs.HasKey("health"))
        {
            PlayerPrefs.SetInt("health", 1);
        }

        if (!PlayerPrefs.HasKey("maxbonus"))
        {
            PlayerPrefs.SetInt("maxbonus", 3);
        }

        for (int i = 0; i <= 5; i++) 
        {
            if (!PlayerPrefs.HasKey("item" + i.ToString()))
            {
                PlayerPrefs.SetInt("item" + i.ToString(), 0);
            }
        }
    }
}
