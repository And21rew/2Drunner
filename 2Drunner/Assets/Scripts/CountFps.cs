using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountFps : MonoBehaviour
{
    void Start()
    {
        //PlayerPrefs.DeleteAll();
        Application.targetFrameRate = 60;
    }
}
