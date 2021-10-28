using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] private Text[] count;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        for (int i = 0; i < count.Length; i++)
        {
            count[i].text = PlayerPrefs.GetInt("item" + i.ToString(), PlayerPrefs.GetInt("item" + i.ToString())).ToString();
        }
    }

    public void UseItem0()
    {
        if(PlayerPrefs.GetInt("item0") > 0)
            PlayerPrefs.SetInt("item0", PlayerPrefs.GetInt("item0") - 1);
        // обращение к скрипту игрока и активация эффектов
    }

    public void UseItem1()
    {
        if (PlayerPrefs.GetInt("item1") > 0)
            PlayerPrefs.SetInt("item1", PlayerPrefs.GetInt("item1") - 1);
        // обращение к скрипту игрока и активация эффектов
    }

    public void UseItem2()
    {
        if (PlayerPrefs.GetInt("item2") > 0)
            PlayerPrefs.SetInt("item2", PlayerPrefs.GetInt("item2") - 1);
        // обращение к скрипту игрока и активация эффектов
    }

    public void UseItem3()
    {
        if (PlayerPrefs.GetInt("item3") > 0)
            PlayerPrefs.SetInt("item3", PlayerPrefs.GetInt("item3") - 1);
        // обращение к скрипту игрока и активация эффектов
    }

    public void UseItem4()
    {
        if (PlayerPrefs.GetInt("item4") > 0)
            PlayerPrefs.SetInt("item4", PlayerPrefs.GetInt("item4") - 1);
        // обращение к скрипту игрока и активация эффектов
    }

    public void UseItem5()
    {
        if (PlayerPrefs.GetInt("item5") > 0)
            PlayerPrefs.SetInt("item5", PlayerPrefs.GetInt("item5") - 1);
        // обращение к скрипту игрока и активация эффектов
    }
}
