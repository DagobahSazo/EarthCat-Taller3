using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text scoreText;

    public float valorScore;

    public Text maxScoreText;

    public float maxScore;


    private void Start()
    {
        maxScore = PlayerPrefs.GetFloat("MaxPuntuacion");
        maxScoreText.text = maxScore.ToString("0.00");
    }

    void Update()
    {
        valorScore += Time.deltaTime;

        scoreText.text = valorScore.ToString("0.00");

        if (maxScore < valorScore)
        {
            PlayerPrefs.SetFloat("MaxPuntuacion", valorScore);

            maxScoreText.text = valorScore.ToString("0.00");
        }
    }
}
