using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public float score;
    void Start()
    {
        DisplayScore();

    }


    void Update()
    {
        DisplayScore();
    }
    public void distroyCube()
    {
        score += 1;
        DisplayScore();

    }

    public void DisplayScore()
    {
        scoreText.text = score.ToString();
    }
}
