using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text score;
    [SerializeField] private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        score.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y > 0)
            score.text = "Score: " + ((int)player.transform.position.y).ToString();
    }
}
