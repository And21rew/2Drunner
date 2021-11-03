using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeInGame : MonoBehaviour
{
    private void OnApplicationPause(bool pause)
    {
        PlayerPrefs.SetString("LastSession", DateTime.Now.ToString());
    }
}
