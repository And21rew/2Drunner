using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LearnGame : MonoBehaviour
{
    [SerializeField] private GameObject learnMenu;
    [SerializeField] private GameObject learnGame;

    void Start()
    {
        if ((PlayerPrefs.GetInt("LearnMenu") == 0) && (SceneManager.GetActiveScene().buildIndex == 0))
        {
            learnMenu.SetActive(true);
        }
        else if ((PlayerPrefs.GetInt("LearnGame") == 0) && (SceneManager.GetActiveScene().buildIndex == 1))
        {
            learnGame.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            Debug.Log("exception");
        }
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        PlayerPrefs.SetInt("LearnGame", 1);
    }
}
