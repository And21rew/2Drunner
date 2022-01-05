using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerDontDestroy : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
