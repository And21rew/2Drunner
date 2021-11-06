using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject btnPause;
    [SerializeField] private GameObject[] leftButton;
    [SerializeField] private GameObject[] rightButton;

    public void StartPause()
    {
        Time.timeScale = 0;
        btnPause.SetActive(false);
        leftButton[PlayerPrefs.GetInt("skin")].SetActive(false);
        rightButton[PlayerPrefs.GetInt("skin")].SetActive(false);
    }

    public void StopPause()
    {
        Time.timeScale = 1;
        btnPause.SetActive(true);
        leftButton[PlayerPrefs.GetInt("skin")].SetActive(true);
        rightButton[PlayerPrefs.GetInt("skin")].SetActive(true);
    }
}
