using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnApplicationPause(bool pause)
    {
        TimeSpan timeSpan;
        if (PlayerPrefs.HasKey("LastSession"))
        {
            timeSpan = DateTime.Now - DateTime.Parse(PlayerPrefs.GetString("LastSession"));
            print(string.Format("¬ы отсутствовали: {0} дней, {1} часов, {2} минут, {3} секунд", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds));
        }
        PlayerPrefs.SetString("LastSession", DateTime.Now.ToString());
    }
}
