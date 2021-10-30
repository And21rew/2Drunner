using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSkins : MonoBehaviour
{
    [SerializeField] private Button[] btns;

    private void Start()
    {
        btns[PlayerPrefs.GetInt("skin")].interactable = false;
    }

    public void ChangeSkin(int id)
    {
        PlayerPrefs.SetInt("skin", id);
        btns[id].interactable = false;
    }
}
