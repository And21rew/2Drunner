using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject [] btns;

    public void StartPause()
    {
        Time.timeScale = 0;
        for (int i = 0; i < btns.Length; i++)
        {
            btns[i].SetActive(false);
        }
    }

    public void StopPause()
    {
        Time.timeScale = 1;
        for (int i = 0; i < btns.Length; i++)
        {
            btns[i].SetActive(true);
        }
    }
}
