using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadLevel : MonoBehaviour
{
    public void LoadGame()
    {
        Time.timeScale = 1;
        if (PlayerPrefs.GetInt("LearnMenu") == 0)
            PlayerPrefs.SetInt("LearnMenu", 1);
        SceneManager.LoadScene(1);
        PlayerPrefs.SetInt("CheckGame", 1);
    }

    public void LoadMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
