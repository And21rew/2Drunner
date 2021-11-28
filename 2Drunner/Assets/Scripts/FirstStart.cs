using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstStart : MonoBehaviour
{
    void Start()
    {
        //PlayerPrefs.DeleteAll();
        //PlayerPrefs.SetInt("coin", 500000);

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

        if (!PlayerPrefs.HasKey("skin"))
        {
            PlayerPrefs.SetInt("skin", 0);
        }

        if (!PlayerPrefs.HasKey("canClean0"))
        {
            PlayerPrefs.SetInt("canClean0", 0);
        }

        if (!PlayerPrefs.HasKey("canClean1"))
        {
            PlayerPrefs.SetInt("canClean1", 0);
        }

        if (!PlayerPrefs.HasKey("canClean2"))
        {
            PlayerPrefs.SetInt("canClean2", 0);
        }

        for (int i = 0; i <= 5; i++) 
        {
            if (!PlayerPrefs.HasKey("item" + i.ToString()))
            {
                PlayerPrefs.SetInt("item" + i.ToString(), 0);
            }
        }

        PlayerPrefs.SetInt("LockDragon0", 1);

        if (!PlayerPrefs.HasKey("LockDragon1"))
        {
            PlayerPrefs.SetInt("LockDragon1", 0);
        }

        if (!PlayerPrefs.HasKey("LockDragon2"))
        {
            PlayerPrefs.SetInt("LockDragon2", 0);
        }

        if (!PlayerPrefs.HasKey("LockDragon3"))
        {
            PlayerPrefs.SetInt("LockDragon3", 0);
        }

        if (!PlayerPrefs.HasKey("LockDragon4"))
        {
            PlayerPrefs.SetInt("LockDragon4", 0);
        }

        if (!PlayerPrefs.HasKey("TimeClean0"))
        {
            PlayerPrefs.SetFloat("TimeClean0", 0f);
        }

        if (!PlayerPrefs.HasKey("TimeClean1"))
        {
            PlayerPrefs.SetFloat("TimeClean1", 0f);
        }

        if (!PlayerPrefs.HasKey("TimeClean2"))
        {
            PlayerPrefs.SetFloat("TimeClean2", 0f);
        }
    }
}
