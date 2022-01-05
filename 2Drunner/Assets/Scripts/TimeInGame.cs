using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeInGame : MonoBehaviour
{
    private float timeInGame;

    private void Update()
    {
        timeInGame += Time.deltaTime;
        PlayerPrefs.SetInt("TimeInGame", (int)timeInGame);
    }
    private void OnApplicationPause(bool pause)
    {
        PlayerPrefs.GetInt("CheckGame", 0);
        PlayerPrefs.SetString("LastSession", DateTime.Now.ToString());
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.GetInt("CheckGame", 0);
        PlayerPrefs.SetString("LastSession", DateTime.Now.ToString());
    }
}
