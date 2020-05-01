using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Score : MonoBehaviour
{
    public TextElement scoreText;
    public float score;
    void Start()
    {

    }


    void Update()
    {

    }
    public void distroyCube()
    {
        score += 1;
        scoreText.text = score.ToString();
    }
}
