using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Text timerText;
    [SerializeField] private Text timerText1;
    [SerializeField] private Text timerText2;
    [SerializeField] private GameObject warn, warnItem;
    [SerializeField] private Image cleaner0, cleaner1, cleaner2;
    [SerializeField] private Sprite item0, item1, item2, cleaner;
    private float tm1, tm2, tm, tmm, tm3, tm4, tmmm;
    private float timeLeft = 0f;
    private float timeLeft1 = 0f;
    private float timeLeft2 = 0f;
    private float timeSec;

    private void Start()
    {
        tm1 = PlayerPrefs.GetFloat("cleaner0");
        tm3 = PlayerPrefs.GetFloat("cleaner1");
        tm4 = PlayerPrefs.GetFloat("cleaner2");
        tm2 = PlayerPrefs.GetFloat("tm2");
        tm = tm1 - tm2;
        tmm = tm3 - tm2;
        tmmm = tm4 - tm2;
        if (tm <= 0)
        {
            PlayerPrefs.SetInt("canClean0", 0);
            cleaner0.sprite = cleaner;
            if (PlayerPrefs.GetFloat("TimeClean0") == 900)
            {
                PlayerPrefs.SetInt("item3", PlayerPrefs.GetInt("item3") + 1);
                PlayerPrefs.SetFloat("TimeClean0", 0);
            }
            else if (PlayerPrefs.GetFloat("TimeClean0") == 3600)
            {
                PlayerPrefs.SetInt("item4", PlayerPrefs.GetInt("item4") + 1);
                PlayerPrefs.SetFloat("TimeClean0", 0);
            }
            else if (PlayerPrefs.GetFloat("TimeClean0") == 18000)
            {
                PlayerPrefs.SetInt("item5", PlayerPrefs.GetInt("item5") + 1);
                PlayerPrefs.SetFloat("TimeClean0", 0);
            }
        }
        else
        {
            if (PlayerPrefs.GetFloat("TimeClean0") == 900)
            {
                cleaner0.sprite = item0;
            }
            else if (PlayerPrefs.GetFloat("TimeClean0") == 3600)
            {
                cleaner0.sprite = item1;
            }
            else if (PlayerPrefs.GetFloat("TimeClean0") == 18000)
            {
                cleaner0.sprite = item2;
            }
            StartCoroutine(StartTimer(tm));
        }

        if (tmm <= 0)
        {
            PlayerPrefs.SetInt("canClean1", 0);
            cleaner1.sprite = cleaner;
            if (PlayerPrefs.GetFloat("TimeClean1") == 900)
            {
                PlayerPrefs.SetInt("item3", PlayerPrefs.GetInt("item3") + 1);
                PlayerPrefs.SetFloat("TimeClean1", 0);
            }
            else if (PlayerPrefs.GetFloat("TimeClean1") == 3600)
            {
                PlayerPrefs.SetInt("item4", PlayerPrefs.GetInt("item4") + 1);
                PlayerPrefs.SetFloat("TimeClean1", 0);
            }
            else if (PlayerPrefs.GetFloat("TimeClean1") == 18000)
            {
                PlayerPrefs.SetInt("item5", PlayerPrefs.GetInt("item5") + 1);
                PlayerPrefs.SetFloat("TimeClean1", 0);
            }
        }
        else
        {
            if (PlayerPrefs.GetFloat("TimeClean1") == 900)
            {
                cleaner1.sprite = item0;
            }
            else if (PlayerPrefs.GetFloat("TimeClean1") == 3600)
            {
                cleaner1.sprite = item1;
            }
            else if (PlayerPrefs.GetFloat("TimeClean1") == 18000)
            {
                cleaner1.sprite = item2;
            }
            StartCoroutine(StartTimer1(tmm));
        }

        if (tmmm <= 0)
        {
            PlayerPrefs.SetInt("canClean2", 0);
            cleaner2.sprite = cleaner;
            if (PlayerPrefs.GetFloat("TimeClean2") == 10)
            {
                PlayerPrefs.SetInt("item3", PlayerPrefs.GetInt("item3") + 1);
                PlayerPrefs.SetFloat("TimeClean2", 0);
            }
            else if (PlayerPrefs.GetFloat("TimeClean2") == 20)
            {
                PlayerPrefs.SetInt("item4", PlayerPrefs.GetInt("item4") + 1);
                PlayerPrefs.SetFloat("TimeClean2", 0);
            }
            else if (PlayerPrefs.GetFloat("TimeClean2") == 30)
            {
                PlayerPrefs.SetInt("item5", PlayerPrefs.GetInt("item5") + 1);
                PlayerPrefs.SetFloat("TimeClean2", 0);
            }
        }
        else
        {
            if (PlayerPrefs.GetFloat("TimeClean2") == 900)
            {
                cleaner2.sprite = item0;
            }
            else if (PlayerPrefs.GetFloat("TimeClean2") == 3600)
            {
                cleaner2.sprite = item1;
            }
            else if (PlayerPrefs.GetFloat("TimeClean2") == 18000)
            {
                cleaner2.sprite = item2;
            }
            StartCoroutine(StartTimer2(tmmm));
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
            cleaner0.sprite = cleaner;
            PlayerPrefs.SetInt("canClean0", 0);
            if (PlayerPrefs.GetFloat("TimeClean0") == 900)
            {
                PlayerPrefs.SetInt("item3", PlayerPrefs.GetInt("item3") + 1);
                PlayerPrefs.SetFloat("TimeClean0", 0);
            }
            else if (PlayerPrefs.GetFloat("TimeClean0") == 3600)
            {
                PlayerPrefs.SetInt("item4", PlayerPrefs.GetInt("item4") + 1);
                PlayerPrefs.SetFloat("TimeClean0", 0);
            }
            else if (PlayerPrefs.GetFloat("TimeClean0") == 18000)
            {
                PlayerPrefs.SetInt("item5", PlayerPrefs.GetInt("item5") + 1);
                PlayerPrefs.SetFloat("TimeClean0", 0);
            }
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
        if (PlayerPrefs.GetInt("item0") > 0)
        {
            if (PlayerPrefs.GetInt("canClean0") == 0)
            {
                PlayerPrefs.SetInt("canClean0", 1);
                PlayerPrefs.SetFloat("TimeClean0", timeInSecond);
                PlayerPrefs.SetInt("item0", PlayerPrefs.GetInt("item0") - 1);
                cleaner0.sprite = item0;
                StartCoroutine(StartTimer(timeInSecond));
            }
            else if (PlayerPrefs.GetInt("canClean1") == 0)
            {
                PlayerPrefs.SetInt("canClean1", 1);
                PlayerPrefs.SetFloat("TimeClean1", timeInSecond);
                PlayerPrefs.SetInt("item0", PlayerPrefs.GetInt("item0") - 1);
                cleaner1.sprite = item0;
                StartCoroutine(StartTimer1(timeInSecond));
            }
            else if (PlayerPrefs.GetInt("canClean2") == 0)
            {
                PlayerPrefs.SetInt("canClean2", 1);
                PlayerPrefs.SetFloat("TimeClean2", timeInSecond);
                PlayerPrefs.SetInt("item0", PlayerPrefs.GetInt("item0") - 1);
                cleaner2.sprite = item0;
                StartCoroutine(StartTimer2(timeInSecond));
            }
            else
            {
                StartCoroutine(ShowWarn());
            }
        }
        else
        {
            StartCoroutine(ShowWarnItem());
        }
    }

    public void CleanItem1(float timeInSecond)
    {
        if (PlayerPrefs.GetInt("item1") > 0)
        {
            if (PlayerPrefs.GetInt("canClean0") == 0)
            {
                PlayerPrefs.SetInt("canClean0", 1);
                PlayerPrefs.SetFloat("TimeClean0", timeInSecond);
                PlayerPrefs.SetInt("item1", PlayerPrefs.GetInt("item1") - 1);
                cleaner0.sprite = item1;
                StartCoroutine(StartTimer(timeInSecond));
            }
            else if (PlayerPrefs.GetInt("canClean1") == 0)
            {
                PlayerPrefs.SetInt("canClean1", 1);
                PlayerPrefs.SetFloat("TimeClean1", timeInSecond);
                PlayerPrefs.SetInt("item1", PlayerPrefs.GetInt("item1") - 1);
                cleaner1.sprite = item1;
                StartCoroutine(StartTimer1(timeInSecond));
            }
            else if (PlayerPrefs.GetInt("canClean2") == 0)
            {
                PlayerPrefs.SetInt("canClean2", 1);
                PlayerPrefs.SetFloat("TimeClean2", timeInSecond);
                PlayerPrefs.SetInt("item1", PlayerPrefs.GetInt("item1") - 1);
                cleaner2.sprite = item1;
                StartCoroutine(StartTimer2(timeInSecond));
            }
            else
            {
                StartCoroutine(ShowWarn());
            }
        }
        else
        {
            StartCoroutine(ShowWarnItem());
        }
    }

    public void CleanItem2(float timeInSecond)
    {
        if (PlayerPrefs.GetInt("item2") > 0)
        {
            if (PlayerPrefs.GetInt("canClean0") == 0)
            {
                PlayerPrefs.SetInt("canClean0", 1);
                PlayerPrefs.SetFloat("TimeClean0", timeInSecond);
                PlayerPrefs.SetInt("item2", PlayerPrefs.GetInt("item2") - 1);
                cleaner0.sprite = item2;
                StartCoroutine(StartTimer(timeInSecond));
            }
            else if (PlayerPrefs.GetInt("canClean1") == 0)
            {
                PlayerPrefs.SetInt("canClean1", 1);
                PlayerPrefs.SetFloat("TimeClean1", timeInSecond);
                PlayerPrefs.SetInt("item2", PlayerPrefs.GetInt("item2") - 1);
                cleaner1.sprite = item2;
                StartCoroutine(StartTimer1(timeInSecond));
            }
            else if (PlayerPrefs.GetInt("canClean2") == 0)
            {
                PlayerPrefs.SetInt("canClean2", 1);
                PlayerPrefs.SetFloat("TimeClean2", timeInSecond);
                PlayerPrefs.SetInt("item2", PlayerPrefs.GetInt("item2") - 1);
                cleaner2.sprite = item2;
                StartCoroutine(StartTimer2(timeInSecond));
            }
            else
            {
                StartCoroutine(ShowWarn());
            }
        }
        else
        {
            StartCoroutine(ShowWarnItem());
        }
    }

    IEnumerator ShowWarn()
    {
        warn.SetActive(true);
        yield return new WaitForSeconds(3f);
        warn.SetActive(false);
    }

    IEnumerator ShowWarnItem()
    {
        warnItem.SetActive(true);
        yield return new WaitForSeconds(3f);
        warnItem.SetActive(false);
    }

    private void UpdateTimeText1()
    {
        PlayerPrefs.SetFloat("cleaner1", timeLeft1);
        if (timeLeft1 < 0)
        {
            timeLeft1 = 0;
            cleaner1.sprite = cleaner;
            PlayerPrefs.SetInt("canClean1", 0);
            if (PlayerPrefs.GetFloat("TimeClean1") == 900)
            {
                PlayerPrefs.SetInt("item3", PlayerPrefs.GetInt("item3") + 1);
                PlayerPrefs.SetFloat("TimeClean1", 0);
            }
            else if (PlayerPrefs.GetFloat("TimeClean1") == 3600)
            {
                PlayerPrefs.SetInt("item4", PlayerPrefs.GetInt("item4") + 1);
                PlayerPrefs.SetFloat("TimeClean1", 0);
            }
            else if (PlayerPrefs.GetFloat("TimeClean1") == 18000)
            {
                PlayerPrefs.SetInt("item5", PlayerPrefs.GetInt("item5") + 1);
                PlayerPrefs.SetFloat("TimeClean1", 0);
            }
        }
        float hours = Mathf.FloorToInt(timeLeft1 / 3600);
        float minutes = Mathf.FloorToInt(timeLeft1 % 3600 / 60);
        float seconds = Mathf.FloorToInt(timeLeft1 % 60);

        timerText1.text = string.Format("{0:00} : {1:00} : {2:00}", hours, minutes, seconds);
    }

    private IEnumerator StartTimer1(float time)
    {
        timeLeft1 = time;
        while (timeLeft1 > 0)
        {
            timeLeft1 -= Time.deltaTime;
            UpdateTimeText1();
            yield return null;
        }
    }

    private void UpdateTimeText2()
    {
        PlayerPrefs.SetFloat("cleaner2", timeLeft2);
        if (timeLeft2 < 0)
        {
            timeLeft2 = 0;
            cleaner2.sprite = cleaner;
            PlayerPrefs.SetInt("canClean2", 0);
            if (PlayerPrefs.GetFloat("TimeClean2") == 900)
            {
                PlayerPrefs.SetInt("item3", PlayerPrefs.GetInt("item3") + 1);
                PlayerPrefs.SetFloat("TimeClean2", 0);
            }
            else if (PlayerPrefs.GetFloat("TimeClean2") == 3600)
            {
                PlayerPrefs.SetInt("item4", PlayerPrefs.GetInt("item4") + 1);
                PlayerPrefs.SetFloat("TimeClean2", 0);
            }
            else if (PlayerPrefs.GetFloat("TimeClean2") == 18000)
            {
                PlayerPrefs.SetInt("item5", PlayerPrefs.GetInt("item5") + 1);
                PlayerPrefs.SetFloat("TimeClean2", 0);
            }
        }
        float hours = Mathf.FloorToInt(timeLeft2 / 3600);
        float minutes = Mathf.FloorToInt(timeLeft2 % 3600 / 60);
        float seconds = Mathf.FloorToInt(timeLeft2 % 60);

        timerText2.text = string.Format("{0:00} : {1:00} : {2:00}", hours, minutes, seconds);
    }

    private IEnumerator StartTimer2(float time)
    {
        timeLeft2 = time;
        while (timeLeft2 > 0)
        {
            timeLeft2 -= Time.deltaTime;
            UpdateTimeText2();
            yield return null;
        }
    }
}
