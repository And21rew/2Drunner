using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    private int health = 1;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject score;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            health--;

            if (health <= 0)
            {
                Time.timeScale = 0;
                score.SetActive(false);
                gameOverPanel.SetActive(true);
            }
        }
    }
}
