using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSkins : MonoBehaviour
{
    [SerializeField] private Button[] btns;

    private void Update()
    {
        for (int i = 0; i < btns.Length; i++)
        {
            if (i == PlayerPrefs.GetInt("skin"))
            {
                btns[i].interactable = false;
            }
            else
            {
                btns[i].interactable = true;
            }
        }
    }

    public void ChangeSkin(int id)
    {
        PlayerPrefs.SetInt("skin", id);
    }
}
