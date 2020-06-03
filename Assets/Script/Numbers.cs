using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Numbers : MonoBehaviour
{


    public TextMesh bp;

    public Text LOSS;
    public float score = 10;
    void Start()
    {
        InvokeRepeating("MinusScore", 1, 1);
        DisplayScore();
    }

    public void MinusScore()
    {

        score -= 1;
        DisplayScore();
        if (score <= 0)
        {
            LOSS.enabled = !LOSS.enabled;
            CancelInvoke("timer");
        }
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
        bp.text = score.ToString();
    }
}
