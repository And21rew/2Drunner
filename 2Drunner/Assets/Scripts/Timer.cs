using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Text timerText;
    [SerializeField] private GameObject warn;
    private bool cleaner0, cleaner1, cleaner2 = true;
    private float tm1, tm2, tm;
    private float timeLeft = 0f;
    private float timeSec;

    private void Start()
    {
        if (PlayerPrefs.HasKey("LastSession"))
        {
            tm1 = PlayerPrefs.GetFloat("cleaner0");
            tm2 = PlayerPrefs.GetFloat("tm2");
            tm = tm1 - tm2;
            StartCoroutine(StartTimer(tm));
        }
    }

    private void OnApplicationPause(bool pause)
    {
        TimeSpan timeSpan;
        if (PlayerPrefs.HasKey("LastSession"))
        {
            timeSpan = DateTime.Now - DateTime.Parse(PlayerPrefs.GetString("LastSession"));
            print(string.Format("¬ы отсутствовали: {0} дней, {1} часов, {2} минут, {3} секунд", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds));
            timeSec = timeSpan.Hours * 3600 + timeSpan.Minutes * 60 + timeSpan.Seconds;
            PlayerPrefs.SetFloat("tm2", timeSec);
        }
        PlayerPrefs.SetString("LastSession", DateTime.Now.ToString());
    }


    private void UpdateTimeText()
    {
        PlayerPrefs.SetFloat("cleaner0", timeLeft);
        if (timeLeft < 0)
        {
            timeLeft = 0;
        }
        float hours = Mathf.FloorToInt(timeLeft / 3600);
        float minutes = Mathf.FloorToInt(timeLeft % 3600 / 60);
        float seconds = Mathf.FloorToInt(timeLeft % 60);

        timerText.text = string.Format("{0:00} : {1:00} : {2:00}", hours, minutes, seconds);
    }

    private IEnumerator StartTimer(float time)
    {
        timeLeft = time;
        while (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            UpdateTimeText();
            yield return null;
        }
    }

    public void CleanItem0(float timeInSecond)
    {
        if (cleaner0)
        {
            StartCoroutine(StartTimer(timeInSecond));
        }
        else if (cleaner1)
        {
            StartCoroutine(StartTimer(timeInSecond));
        }
        else if (cleaner2)
        {
            StartCoroutine(StartTimer(timeInSecond));
        }
        else
        {
            StartCoroutine(ShowWarn());
        }
    }

    public void CleanItem1(float timeInSecond)
    {
        if (cleaner0)
        {
            StartCoroutine(StartTimer(timeInSecond));
        }
        else if (cleaner1)
        {
            StartCoroutine(StartTimer(timeInSecond));
        }
        else if (cleaner2)
        {
            StartCoroutine(StartTimer(timeInSecond));
        }
        else
        {
            StartCoroutine(ShowWarn());
        }
    }

    public void CleanItem2(float timeInSecond)
    {
        if (cleaner0)
        {
            StartCoroutine(StartTimer(timeInSecond));
        }
        else if (cleaner1)
        {
            StartCoroutine(StartTimer(timeInSecond));
        }
        else if (cleaner2)
        {
            StartCoroutine(StartTimer(timeInSecond));
        }
        else
        {
            StartCoroutine(ShowWarn());
        }
    }

    IEnumerator ShowWarn()
    {
        warn.SetActive(true);
        yield return new WaitForSeconds(3f);
        warn.SetActive(false);
    }
}
